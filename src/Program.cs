using AngleSharp;
using AngleSharp.Dom;

using Madjoki.BBCParser;

using SteamHelpSync;

using System;
using System.Collections.Concurrent;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

// Config
var gitPath = ".";
var listFileName = Path.Combine(gitPath, "list.json");
var faqsPath = Path.Combine(gitPath, "faqs");
var dir = new DirectoryInfo(faqsPath);

if (!dir.Exists)
{
    Console.WriteLine("fags directory doesn't exist.");
    return;
}

Directory.CreateDirectory(faqsPath);

var faqsListing = await FaqsListing.OpenAsync(listFileName, true).ConfigureAwait(false);

var httpClient = new HttpClient();

// Angle Sharp
var config = Configuration.Default;
var context = BrowsingContext.New(config);

var queue = new ConcurrentQueue<string>();
var searched = new HashSet<string>();

Regex slugFormat = new("(?:[A-Z0-9]{4})-(?:[A-Z0-9]{4})-(?:[A-Z0-9]{4})-(?:[A-Z0-9]{4})", RegexOptions.Compiled | RegexOptions.IgnoreCase);
Regex removeMultipleLines = new("(\r\n){2,}", RegexOptions.IgnoreCase);

if (File.Exists("links.txt"))
{
    var links = await File.ReadAllTextAsync("links.txt");
    QueueAllFromString(links);
}

foreach (var item in faqsListing.UrlSlugs)
{
    Queue(item);
}


static string ToFileNameSafe(string filename)
{
    // Builds a string out of valid chars and an _ for invalid ones
    return new string(filename.Select(ch => Path.GetInvalidFileNameChars().Contains(ch) ? '_' : ch).ToArray());
}

void Queue(string slug)
{
    slug = slug.ToUpper();

    if (searched == null)
        return;

    if (!searched.Add(slug))
        return;

    queue?.Enqueue(slug);
}

void QueueAllFromString(string text)
{

    var matches = slugFormat.Matches(text);

    foreach (Match match in matches)
    {
        Queue(match.Value);
    }
}

var options = new JsonSerializerOptions
{
    NumberHandling = JsonNumberHandling.AllowReadingFromString
};
options.Converters.Add(new UnixEpochDateTimeConverter());

while (queue.TryDequeue(out var slug))
{
    faqsListing.UrlSlugs.Add(slug);

    try
    {
        Console.WriteLine($"Updating {slug}");

        var response = await httpClient.GetAsync($"https://help.steampowered.com/en/faqs/view/{slug}").ConfigureAwait(false);

        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

        var document = await context.OpenAsync(req => req.Content(content));

        var test = document.QuerySelector("#application_config");

        if (test == null)
        {
            continue;
        }

        var faqStoreText = test.Attributes["data-faqstore"]?.Value;

        if (faqStoreText == null)
        {
            continue;
        }

        var faqStore = JsonSerializer.Deserialize<FaqStoreJson>(faqStoreText, options);

        if (faqStore == null)
            continue;

        foreach (var item in faqStore.Faqs.Values)
        {
            if (item == null)
            {
                continue;
            }

            if (!faqsListing.KnownFags.ContainsKey(item.FaqID))
            {
                Console.WriteLine($"New! {item.Title}");

                var fileName = ToFileNameSafe(item.Title);

                var fullFileName = Path.Combine(faqsPath, $"{fileName}.txt");
                var i = 1;

                while (File.Exists(fullFileName))
                {
                    fileName = $"{ToFileNameSafe(item.Title)}_{i}";
                    fullFileName = Path.Combine(faqsPath, $"{fileName}.txt");
                    i++;
                }

                faqsListing.KnownFags[item.FaqID] = new FaqsListingItem
                {
                    Slug = slug,
                    FileName = fileName,
                };
            }

            var faq = faqsListing.KnownFags[item.FaqID];

            faq.Slug = slug;
            faq.LastUpdated = item.Timestamp;
            faq.Version = item.Version;

            var jsonFileName = Path.Combine(faqsPath, $"{faq.FileName}.json");
            var mdFileName = Path.Combine(faqsPath, $"{faq.FileName}.md");
            var txtFileName = Path.Combine(faqsPath, $"{faq.FileName}.txt");

            var matches = slugFormat.Matches(item.Content);

            foreach (Match match in matches)
            {
                Queue(match.Value);
            }

            var versionText = JsonSerializer.Serialize(item, new JsonSerializerOptions
            {
                WriteIndented = true,
            });

            await File.WriteAllTextAsync(jsonFileName, versionText).ConfigureAwait(false);

            var trimmedContent = item.Content.Trim();

            trimmedContent = string.Join("\r\n", trimmedContent
                .Replace("[section", "\r\n[section")
                .Replace("[/section]", "\r\n[/section]\r\n")
                .Replace("[exclude_realm", "\r\n[exclude_realm")
                .Replace("[/exclude_realm]", "\r\n[/exclude_realm]\r\n")
                .Replace("[list]", "\r\n[list]\r\n")
                .Replace("[/list]", "\r\n[/list]\r\n")
                .Replace("[olist]", "\r\n[olist]\r\n")
                .Replace("[/olist]", "\r\n[/olist]\r\n")
                .Replace("[*]", "\r\n[*]")
                .Replace("[/*]", " [/*]\r\n")
                .Replace("[hr]", "\r\n[hr]")
                .Replace("[/hr]", "[/hr]\r\n")
                .Replace("[h2]", "\r\n[h2]\r\n")
                .Replace("[/h2]", "\r\n[/h2]\r\n")
                .Replace("[h3]", "\r\n[h3]\r\n")
                .Replace("[/h3]", "\r\n[/h3]\r\n")
                .Split("\r\n")
                .Select(x => x.Trim()));


            trimmedContent = removeMultipleLines.Replace(trimmedContent, "\r\n");

            var sb = new StringBuilder();
            sb.AppendLine(item.Title);
            sb.Append('-', item.Title.Length);
            sb.AppendLine();
            sb.AppendLine($"Updated {item.Timestamp.ToString("yyyy-MM-dd HH:mm:ss")}");
            sb.AppendLine($"Version {item.Version}");
            sb.AppendLine();
            sb.Append(trimmedContent);

            await File.WriteAllTextAsync(txtFileName, sb.ToString()).ConfigureAwait(false);

            sb.Clear();
            sb.Append("# ");
            sb.AppendLine(item.Title);
            sb.AppendLine($"Updated {item.Timestamp.ToString("yyyy-MM-dd HH:mm:ss")}  ");
            sb.AppendLine($"Version {item.Version}  ");
            sb.AppendLine();

            var bbcTree = BBCParser.Parse(item.Content);
            var mdConverted = bbcTree.ToMarkdown().Trim();

            mdConverted = removeMultipleLines.Replace(mdConverted, "\r\n");

            sb.Append(mdConverted);

            await File.WriteAllTextAsync(mdFileName, sb.ToString()).ConfigureAwait(false);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }   
}

// Sorting
faqsListing.UrlSlugs = faqsListing.UrlSlugs.OrderBy(x => x).ToHashSet();
faqsListing.KnownFags = faqsListing.KnownFags.OrderBy(x => x.Value.LastUpdated).ToDictionary(x => x.Key, x => x.Value);

await faqsListing.SaveAsync().ConfigureAwait(false);

var git = ProcessHelper.GetExecutablePath("git.exe");

Console.WriteLine("Commiting git");
await ProcessHelper.RunAsync(git, "add .", workingDirectory: gitPath);
await ProcessHelper.RunAsync(git, $"commit -m {ProcessHelper.Quote($"Updated")}", workingDirectory: gitPath);
await ProcessHelper.RunAsync(git, "push", workingDirectory: gitPath);
Console.WriteLine("Commiting git done!");