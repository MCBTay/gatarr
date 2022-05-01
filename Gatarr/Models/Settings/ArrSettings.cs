namespace Gatarr.Models.Settings;

public interface IArrSettings
{
    string Host { get; set; }
    int Port { get; set; }
    bool UseHttps { get; set; }
    string ApiKey { get; set; }
    bool Enabled { get; set; }
}

public class ArrSettings : IArrSettings
{
    public string Host { get; set; }
    public int Port { get; set; }
    public bool UseHttps { get; set; }
    public string ApiKey { get; set; }
    public bool Enabled { get; set; }
}