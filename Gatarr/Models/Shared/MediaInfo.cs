namespace Gatarr.Models.Shared;

public class MediaInfo
{
    public int audioBitrate { get; set; }
    public double audioChannels { get; set; }
    public string audioCodec { get; set; }
    public string audioLanguages { get; set; }
    public int audioStreamCount { get; set; }
    public int videoBitDepth { get; set; }
    public int videoBitrate { get; set; }
    public string videoCodec { get; set; }
    public string videoDynamicRangeType { get; set; }
    public double videoFps { get; set; }
    public string resolution { get; set; }
    public string runTime { get; set; }
    public string scanType { get; set; }
    public string subtitles { get; set; }
}