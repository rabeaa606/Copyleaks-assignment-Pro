using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs.Download
{
    public class FullSuspectedComparisonDescriptionLayer
    {
        [JsonProperty("chars")]
        public FullSuspectedComparisonLayerValues Chars { get; set; }

        [JsonProperty("words")]
        public FullSuspectedComparisonLayerValues Words { get; set; }
    }
}