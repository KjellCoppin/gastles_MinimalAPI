namespace gastles_MinimalAPI_solution.Models;

public class Motor : Voertuig
{
    public bool Elektrisch { get; set; }

    public override string Toeter()
    {
        return $"{Naam} zegt beep beep";
    }

    public Motor(string naam) : base(naam)
    {

    }

    public override string ToString()
    {
        return base.ToString() + $"\ntype: {((Elektrisch) ? "electrisch" : "diesel" )}";
    }
}
