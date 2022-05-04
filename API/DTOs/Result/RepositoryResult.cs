using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs
{
    public class RepositoryResult : BasicInternalResult
    {
        [JsonProperty("repositoryId")]
        public string RepositoryId { get; set; }
    }
}