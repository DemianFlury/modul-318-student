using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace SwissTransportGUI
{
    internal class JSONLesen
    {

        [JsonPropertyName("city")]
        public string? City { get; set; }

    }
}
