using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs
{
    public class ScoreSection
    {

        [JsonProperty("identicalWords")]
        public uint IdenticalWords { get; set; }
        [JsonProperty("minorChangedWords")]
        public uint MinorChangedWords { get; set; }
        [JsonProperty("relatedMeaningWords")]
        public uint RelatedMeaningWords { get; set; }
        [JsonProperty("aggregatedScore")]
        public double AggregatedScore { get; set; }
    }
}