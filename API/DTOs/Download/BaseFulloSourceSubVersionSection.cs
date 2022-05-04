using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs.Download
{
    public abstract class BaseFulloSourceSubVersionSection
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class FullHtmlSourceSubVersionSection : BaseFulloSourceSubVersionSection
    {

        [JsonProperty("exclude")]
        public FullHtmlSourceExcludeSection Exclude { get; set; }
    }

    public class FullTextSourceSubVersionSection : BaseFulloSourceSubVersionSection
    {

        [JsonProperty("exclude")]
        public FullTextSourceExcludeSection Exclude { get; set; }

        [JsonProperty("pages")]
        public FullSourcePagesSection Pages { get; set; }
    }
}