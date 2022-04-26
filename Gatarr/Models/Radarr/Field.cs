namespace Gatarr.Models.Radarr
{
    public class Field
    {
        public int order { get; set; }
        public string name { get; set; }
        public string label { get; set; }
        public string unit { get; set; }
        public string helpText { get; set; }
        public string helpLink { get; set; }
        public string type { get; set; }
        public bool advanced { get; set; }
        public List<SelectOption> selectOptions { get; set; }
        public string selectOptionsProviderAction { get; set; }
        public string section { get; set; }
        public string hidden { get; set; }
        public string placeholder { get; set; }
    }
}
