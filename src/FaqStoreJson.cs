using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SteamHelpSync
{
    public class FaqStoreJson
    {
        [JsonPropertyName("faqs")]
        public Dictionary<ulong, FaqJson> Faqs { get; set; } = new();
    }
}
