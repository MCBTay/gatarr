namespace Gatarr.Models.Radarr;

public class AlternateTitle
{
    public string sourceType { get; set; }
    public int movieId { get; set; }
    public string title { get; set; }
    public int sourceId { get; set; }
    public int votes { get; set; }
    public int voteCount { get; set; }
    public Language language { get; set; }
    public int id { get; set; }
}