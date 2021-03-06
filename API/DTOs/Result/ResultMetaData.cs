using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API.DTOs
{
    public class ResultMetaData
    {
        [JsonProperty("finalUrl")]
        public string FinalUrl { get; set; }

        [JsonProperty("canonicalUrl")]
        public string CanonicalUrl { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("lastModificationDate")]
        public string LastModificationDate { get; set; }

        [JsonProperty("submissionDate")]
        public string SubmissionDate { get; set; }

        [JsonProperty("submittedBy")]
        public string SubmittedBy { get; set; }
    }
}