namespace Gatarr.Models.Radarr
{
    public class Specification
    {
        public int id { get; set; }
        public string name { get; set; }
        public string implementation { get; set; }
        public string implementationName { get; set; }
        public string infoLink { get; set; }
        public bool negate { get; set; }
        public bool required { get; set; }
        public List<Field> fields { get; set; }
        public List<object> presets { get; set; }
    }
}
