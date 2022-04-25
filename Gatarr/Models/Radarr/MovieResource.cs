namespace Gatarr.Models.Radarr
{
    public class MovieResource
    {
        public string title { get; set; }
        public string originalTitle { get; set; }
        public OriginalLanguage originalLanguage { get; set; }
        public List<AlternateTitle> alternateTitles { get; set; }
        public int secondaryYearSourceId { get; set; }
        public string sortTitle { get; set; }
        public object sizeOnDisk { get; set; }
        public string status { get; set; }
        public string overview { get; set; }
        public DateTime inCinemas { get; set; }
        public DateTime physicalRelease { get; set; }
        public DateTime digitalRelease { get; set; }
        public List<Image> images { get; set; }
        public string website { get; set; }
        public int year { get; set; }
        public bool hasFile { get; set; }
        public string youTubeTrailerId { get; set; }
        public string studio { get; set; }
        public string path { get; set; }
        public int qualityProfileId { get; set; }
        public bool monitored { get; set; }
        public string minimumAvailability { get; set; }
        public bool isAvailable { get; set; }
        public string folderName { get; set; }
        public int runtime { get; set; }
        public string cleanTitle { get; set; }
        public string imdbId { get; set; }
        public int tmdbId { get; set; }
        public string titleSlug { get; set; }
        public string certification { get; set; }
        public List<string> genres { get; set; }
        public List<object> tags { get; set; }
        public DateTime added { get; set; }
        public Ratings ratings { get; set; }
        public MovieFile movieFile { get; set; }
        public int id { get; set; }
        public Collection collection { get; set; }
    }


}
