using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs.Download
{
    public class FullSuspectedStatisticsSection
    {
        [JsonProperty("identical")]
        public int Identical { get; set; }

        [JsonProperty("minorChanges")]
        public int MinorChanges { get; set; }

        [JsonProperty("relatedMeaning")]
        public int RelatedMeaning { get; set; }
    }
}