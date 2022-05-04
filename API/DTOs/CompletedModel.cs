using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class CompletedModel
    {
        public int Status { get; set; }
        public string DeveloperPayload { get; set; }
        public ScannedDocument ScannedDocument { get; set; }
        public Results Results { get; set; }
        public DownloadableReport DownloadableReport { get; set; }
        public Notifications Notifications { get; set; }
    }
    public class ScannedDocument
    {
        public string scanId { get; set; }
        public int totalWords { get; set; }
        public int totalExcluded { get; set; }
        public int credits { get; set; }
        public string creationTime { get; set; }
        public Metadata metadata { get; set; }

    }

    public class Internet
    {
        public string id { get; set; }
        public string title { get; set; }
        public string introduction { get; set; }
        public int matchedWords { get; set; }
        public string url { get; set; }
        public Metadata metadata { get; set; }

    }

    public class Database
    {
        public string id { get; set; }
        public string title { get; set; }
        public string introduction { get; set; }
        public int matchedWords { get; set; }
        public string scanId { get; set; }
        public Metadata metadata { get; set; }

    }
    public class Batch
    {
        public string id { get; set; }
        public string title { get; set; }
        public string introduction { get; set; }
        public int matchedWords { get; set; }
        public string scanId { get; set; }
        public Metadata metadata { get; set; }

    }
    public class Metadata
    {
        public string finalUrl { get; set; }
        public string canonicalUrl { get; set; }
        public string author { get; set; }
        public string organization { get; set; }
        public string filename { get; set; }
        public string publishDate { get; set; }
        public string creationDate { get; set; }
        public string lastModificationDate { get; set; }
        public string submittedBy { get; set; }

    }
    public class Repositories
    {
        public string id { get; set; }
        public string title { get; set; }
        public string introduction { get; set; }
        public int matchedWords { get; set; }
        public string repositoryId { get; set; }
        public string scanId { get; set; }
        public Metadata metadata { get; set; }

    }
    public class Score
    {
        public int identicalWords { get; set; }
        public int minorChangedWords { get; set; }
        public int relatedMeaningWords { get; set; }
        public int aggregatedScore { get; set; }

    }
    public class Results
    {
        public IList<Internet> internet { get; set; }
        public IList<Database> database { get; set; }
        public IList<Batch> batch { get; set; }
        public IList<Repositories> repositories { get; set; }
        public Score score { get; set; }

    }
    public class DownloadableReport
    {
        public DateTime status { get; set; }
        public string report { get; set; }

    }
    public class Alerts
    {
        public string code { get; set; }
        public string title { get; set; }
        public string message { get; set; }
        public string helpLink { get; set; }
        public int severity { get; set; }
        public string additionalData { get; set; }

    }
    public class Notifications
    {
        public IList<Alerts> alerts { get; set; }

    }

}
