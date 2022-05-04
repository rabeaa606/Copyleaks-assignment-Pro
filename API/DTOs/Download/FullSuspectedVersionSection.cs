using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs.Download
{
    public abstract class FullSuspectedVersionSection<FULL_SUSPECTED_COMPARISON_DESCRIPTION>
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("pages")]
        public FullSuspectedPagesSection Pages { get; set; }

        [JsonProperty("comparison")]
        public FULL_SUSPECTED_COMPARISON_DESCRIPTION Comparison { get; set; }
    }

    public class FullTextSuspectedVersionSection : FullSuspectedVersionSection<FullTextSuspectedComparisonSection> { }

    public class FullHtmlSuspectedVersionSection : FullSuspectedVersionSection<FullHtmlSuspectedComparisonSection> { }

}