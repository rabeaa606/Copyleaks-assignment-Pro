using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs.Download
{
    public class MetadataSection
    {
        [JsonProperty("words")]
        public ushort Words { get; set; }

        [JsonProperty("excluded")]
        public ushort Excluded { get; set; }
    }
}