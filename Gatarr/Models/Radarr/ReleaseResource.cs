namespace Gatarr.Models.Radarr
{
    public class ReleaseResource
    {
        public string guid { get; set; }
        public Quality quality { get; set; }
        public List<CustomFormat> customFormats { get; set; }
        public int customFormatScore { get; set; }
        public int qualityWeight { get; set; }
        public int age { get; set; }
        public double ageHours { get; set; }
        public double ageMinutes { get; set; }
        public long size { get; set; }
        public int indexerId { get; set; }
        public string indexer { get; set; }
        public string releaseGroup { get; set; }
        public string releaseHash { get; set; }
        public string title { get; set; }
        public bool sceneSource { get; set; }
        public List<string> movieTitles { get; set; }
        public List<Language> languages { get; set; }
        public bool approved { get; set; }
        public bool temporarilyRejected { get; set; }
        public bool rejected { get; set; }
        public int tmdbId { get; set; }
        public int imdbId { get; set; }
        public List<string> rejections { get; set; }
        public DateTime publishDate { get; set; }
        public string commentUrl { get; set; }
        public string downloadUrl { get; set; }
        public string infoUrl { get; set; }
        public bool downloadAllowed { get; set; }
        public int releaseWeight { get; set; }
        public List<object> indexerFlags { get; set; }
        public string edition { get; set; }
        public string protocol { get; set; }
    }
}
