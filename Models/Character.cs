using System.Collections.Generic;

namespace Alien_Universe_DB.Models;

public class Character
{
    public string FullName { get; set; }
    public List<string> Movies { get; set; }
    public string Role { get; set; }
    public string Actor { get; set; }
    public string Species { get; set; }
    public int BirthYear { get; set; }
    public string CrewFunction { get; set; }
    public string Traits { get; set; }
    public string Fate { get; set; }
    public string Trivia { get; set; }
}