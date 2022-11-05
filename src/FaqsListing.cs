using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SteamHelpSync
{
    internal class FaqsListing
    {
        [JsonIgnore]
        public string? Path { get; set; }

        public HashSet<string> UrlSlugs { get; set; } = new();

        public Dictionary<ulong, FaqsListingItem> KnownFags { get; set; } = new();

        public FaqsListing()
        {
        }

        public static async Task<FaqsListing> OpenAsync(string path, bool create = false)
        {
            if (File.Exists(path))
            {
                var text = await File.ReadAllTextAsync(path).ConfigureAwait(false);
                var versions = JsonSerializer.Deserialize<FaqsListing>(text);

                if (versions != null)
                {
                    versions.Path = path;
                    return versions;
                }
            }
            else if (!create)
            {
                throw new FileNotFoundException(message: null, fileName: path);
            }

            var file = new FaqsListing
            {
                Path = path
            };

            return file;
        }

        public async Task SaveAsync()
        {
            if (Path == null)
            {
                return;
            }

            var versionText = JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true,
            });

            await File.WriteAllTextAsync(Path, versionText).ConfigureAwait(false);
        }
    }
}
