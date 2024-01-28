using System.Drawing;

namespace gastles_MinimalAPI_solution.Models;

public class Auto : Voertuig
{
    public string? Aandrijving { get; set; }
    public int Zetels { get; set; }

    public Auto(string naam) : base(naam)
    {
    
    }

    public override string ToString()
    {
        return base.ToString() + $"\naandrijving: {Aandrijving}\naantal zetels: {Zetels}";
    }
}
