using System.Collections.Generic;

namespace Alien_Universe_DB.Models;

public class Movie
{
    public string OriginalTitle { get; set; }
    public string PolishTitle { get; set; }
    public int ReleaseYear { get; set; }
    public string Director { get; set; }
    public string Screenwriter { get; set; }
    public string Genre { get; set; }
    public int DurationMinutes { get; set; }
    public double ImdbRating { get; set; }
    public List<string> MainCharacters { get; set; }
    public string ShipName { get; set; }
    public string PlotSummary { get; set; }
    public string Trivia { get; set; }
}