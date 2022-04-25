namespace Gatarr.Models.Sonarr;

public class Statistics
{
    public DateTime previousAiring { get; set; }
    public int episodeFileCount { get; set; }
    public int episodeCount { get; set; }
    public int totalEpisodeCount { get; set; }
    public object sizeOnDisk { get; set; }
    public double percentOfEpisodes { get; set; }
}