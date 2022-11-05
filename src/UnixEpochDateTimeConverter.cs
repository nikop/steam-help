using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SteamHelpSync
{
    sealed class UnixEpochDateTimeConverter : JsonConverter<DateTimeOffset>
    {
        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var str = reader.GetUInt32();

            return DateTimeOffset.FromUnixTimeSeconds(str);
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            var unixTime = value.ToUnixTimeSeconds();

            string formatted = FormattableString.Invariant($"{unixTime}");
            writer.WriteStringValue(formatted);
        }
    }
}
