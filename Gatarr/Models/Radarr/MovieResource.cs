namespace Gatarr.Models.Radarr
{
    

    public class MediaCover
    {
        public string CoverType { get; set; }
        public string? Url { get; set; }
        public string? RemoteUrl { get; set; }
    }

    public class MovieResource
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? OriginalTitle { get; set; }
        //public Language OriginalLanguage { get; set; }
        //public List<AlternativeTitleResource> AlternativeTitles { get; set; }
        public int? SecondaryYear { get; set; }
        public int SecondaryYearSourceId { get; set; }
        public long? SizeOnDisk { get; set; }
        public string Status { get; set; }
        public string? Overview { get; set; }
        public string? InCinemas { get; set; }
        public string? PhysicalRelease { get; set; }
        public string? DigitalRelease { get; set; }
        public string? PhysicalReleaseNote { get; set; }
        public List<MediaCover> Images { get; set; } = new List<MediaCover>();
        public int Year { get; set; }
        public string? Studio { get; set; }
        public int Runtime { get; set; }
    }
}
