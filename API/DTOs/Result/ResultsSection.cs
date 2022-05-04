using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs
{
    public class ResultsSection
    {
        [JsonProperty("internet")]
        public InternetResult[] Internet { get; set; }

        [JsonProperty("database")]
        public DatabaseResult[] Database { get; set; }

        [JsonProperty("batch")]
        public BatchResult[] Batch { get; set; }

        [JsonProperty("repositories")]
        public RepositoryResult[] Repositories { get; set; }

        [JsonProperty("score")]
        public ScoreSection Score { get; set; }
    }
}