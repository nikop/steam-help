using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SteamHelpSync
{
    public class FaqJson
    {
        /*    
            "author_account_id": null*/

        [JsonPropertyName("faq_id")]
        public ulong FaqID { get; set; }

        [JsonPropertyName("language")]
        public uint Language { get; set; }

        [JsonPropertyName("version")]
        public uint Version { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

    }
}
