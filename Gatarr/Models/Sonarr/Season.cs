namespace Gatarr.Models.Sonarr;

public class Season
{
    public int seasonNumber { get; set; }
    public bool monitored { get; set; }
    public Statistics statistics { get; set; }
}