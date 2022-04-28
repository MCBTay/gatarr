using Gatarr.Models.Shared;

namespace Gatarr.Models.Sonarr
{
    public class EpisodeFile
    {
        public int seriesId { get; set; }
        public int seasonNumber { get; set; }
        public string relativePath { get; set; }
        public string path { get; set; }
        public int size { get; set; }
        public DateTime dateAdded { get; set; }
        public Language language { get; set; }
        public Quality quality { get; set; }
        public MediaInfo mediaInfo { get; set; }
        public bool qualityCutoffNotMet { get; set; }
        public bool languageCutoffNotMet { get; set; }
        public int id { get; set; }
        public string sceneName { get; set; }
        public string releaseGroup { get; set; }
    }
}
