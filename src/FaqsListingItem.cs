using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamHelpSync
{
    internal class FaqsListingItem
    {
        public string Slug { get; set; } = "";

        public string FileName { get; set; } = "";

        public DateTimeOffset? LastUpdated { get; set; }

        public uint Version { get; set; }
    }
}
