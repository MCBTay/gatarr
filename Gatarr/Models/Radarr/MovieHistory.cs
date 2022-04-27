using Gatarr.Models.Shared;

namespace Gatarr.Models.Radarr
{
    public class MovieHistory
    {
        public int id { get; set; }
        public int movieId { get; set; }
        public string sourceTitle { get; set; }
        public List<Language> languages { get; set; }
        public QualityModel quality { get; set; }
        public List<CustomFormat> customFormats { get; set; }
        public bool qualityCutoffNotMet { get; set; }
        public DateTime date { get; set; }
        public string downloadId { get; set; }
        public string eventType { get; set; }
        public Data data { get; set; }
        public MovieResource movie { get; set; }
    }
}
