using Gatarr.Models.Shared;

namespace Gatarr.Models.Radarr
{
    public class Credit
    {
        public string personName { get; set; }
        public string creditTmdbId { get; set; }
        public int personTmdbId { get; set; }
        public int movieId { get; set; }
        public List<Image> images { get; set; }
        public string character { get; set; }
        public int order { get; set; }
        public string type { get; set; }
        public int id { get; set; }
        public string department { get; set; }
        public string job { get; set; }
    }
}
