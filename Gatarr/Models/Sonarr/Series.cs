namespace Gatarr.Models;

public class Series
{
    public string title { get; set; }
    public List<AlternateTitle> alternateTitles { get; set; }
    public string sortTitle { get; set; }
    public int seasonCount { get; set; }
    public int totalEpisodeCount { get; set; }
    public int episodeCount { get; set; }
    public int episodeFileCount { get; set; }
    public long sizeOnDisk { get; set; }
    public string status { get; set; }
    public string overview { get; set; }
    public DateTime previousAiring { get; set; }
    public string network { get; set; }
    public string airTime { get; set; }
    public List<Image> images { get; set; }
    public List<Season> seasons { get; set; }
    public int year { get; set; }
    public string path { get; set; }
    public int profileId { get; set; }
    public int languageProfileId { get; set; }
    public bool seasonFolder { get; set; }
    public bool monitored { get; set; }
    public bool useSceneNumbering { get; set; }
    public int runtime { get; set; }
    public int tvdbId { get; set; }
    public int tvRageId { get; set; }
    public int tvMazeId { get; set; }
    public DateTime firstAired { get; set; }
    public DateTime lastInfoSync { get; set; }
    public string seriesType { get; set; }
    public string cleanTitle { get; set; }
    public string imdbId { get; set; }
    public string titleSlug { get; set; }
    public string certification { get; set; }
    public List<string> genres { get; set; }
    public List<object> tags { get; set; }
    public DateTime added { get; set; }
    public Ratings ratings { get; set; }
    public int qualityProfileId { get; set; }
    public int id { get; set; }
}