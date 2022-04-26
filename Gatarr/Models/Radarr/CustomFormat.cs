namespace Gatarr.Models.Radarr
{
    public class CustomFormat
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool includeCustomFormatWhenRenaming { get; set; }
        public List<Specification> specifications { get; set; }
    }
}
