using Gatarr.Models.Shared;

namespace Gatarr.Models.Radarr;

public class MovieFile
{
    public int movieId { get; set; }
    public string relativePath { get; set; }
    public string path { get; set; }
    public long size { get; set; }
    public DateTime dateAdded { get; set; }
    public int indexerFlags { get; set; }
    public Quality quality { get; set; }
    public MediaInfo mediaInfo { get; set; }
    public bool qualityCutoffNotMet { get; set; }
    public List<Language> languages { get; set; }
    public string edition { get; set; }
    public int id { get; set; }
    public string sceneName { get; set; }
    public string originalFilePath { get; set; }
    public string releaseGroup { get; set; }
    public List<CustomFormat> customFormats { get; set; }
}