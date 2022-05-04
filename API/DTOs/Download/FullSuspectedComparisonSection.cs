using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs.Download
{
    public abstract class FullSuspectedComparisonSection<FULL_SUSPECTED_COMPARISON_DESCRIPTION>
    {
        [JsonProperty("identical")]
        public
        FULL_SUSPECTED_COMPARISON_DESCRIPTION Identical
        { get; set; }

        [JsonProperty("minorChanges")]
        public FULL_SUSPECTED_COMPARISON_DESCRIPTION MinorChanges { get; set; }

        [JsonProperty("relatedMeaning")]
        public FULL_SUSPECTED_COMPARISON_DESCRIPTION RelatedMeaning { get; set; }
    }
    public class FullTextSuspectedComparisonSection : FullSuspectedComparisonSection<FullTextSuspectedComparisonDescription>
    {
    }

    public class FullHtmlSuspectedComparisonSection : FullSuspectedComparisonSection<FullHtmlSuspectedComparisonDescription>
    {
    }
}