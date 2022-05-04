using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs.Download
{
    public class FullTextSuspectedComparisonDescription
    {
        [JsonProperty("source")]
        public FullSuspectedComparisonDescriptionLayer Source { get; set; }

        [JsonProperty("suspected")]
        public FullSuspectedComparisonDescriptionLayer Suspected { get; set; }
    }

    public class FullHtmlSuspectedComparisonDescription : FullTextSuspectedComparisonDescription
    {
        [JsonProperty("groupId")]
        public int[] GroupId { get; set; }
    }
}