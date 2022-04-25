namespace Gatarr.Models.Radarr;

public class Ratings
{
    public Imdb imdb { get; set; }
    public Tmdb tmdb { get; set; }
    public Metacritic metacritic { get; set; }
    public RottenTomatoes rottenTomatoes { get; set; }
}