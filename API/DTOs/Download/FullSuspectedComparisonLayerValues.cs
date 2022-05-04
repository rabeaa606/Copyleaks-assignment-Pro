using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs.Download
{
    public class FullSuspectedComparisonLayerValues
    {
        [JsonProperty("starts")]
        public int[] Starts { get; set; }

        [JsonProperty("lengths")]
        public int[] Lengths { get; set; }
    }
}