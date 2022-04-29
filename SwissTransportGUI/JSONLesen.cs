using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace SwissTransportGUI
{
    internal class JSONLesen
    {

        [JsonPropertyName("latitude")]
        public decimal Latitude { get; set; }


        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }
        JsonSerializer
    }
}
