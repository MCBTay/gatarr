namespace Gatarr.Models.Radarr
{
    public class Data
    {
        public string sourcePath { get; set; }
        public string sourceRelativePath { get; set; }
        public string path { get; set; }
        public string relativePath { get; set; }
        public string releaseGroup { get; set; }
        public string fileId { get; set; }
        public string droppedPath { get; set; }
        public string importedPath { get; set; }
        public string downloadClient { get; set; }
        public string downloadClientName { get; set; }
        public string indexer { get; set; }
        public string nzbInfoUrl { get; set; }
        public string age { get; set; }
        public string ageHours { get; set; }
        public string ageMinutes { get; set; }
        public DateTime? publishedDate { get; set; }
        public string size { get; set; }
        public string downloadUrl { get; set; }
        public string guid { get; set; }
        public string tmdbId { get; set; }
        public string protocol { get; set; }
        public string indexerFlags { get; set; }
        public string indexerId { get; set; }
    }
}
