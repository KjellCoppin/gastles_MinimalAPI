namespace gastles_MinimalAPI_solution.Models;

public abstract class Voertuig : IVoertuig
{
    public string Naam { get; }
    public bool Aan { get; private set; } = false;
    public int TopSnelheid { get; set; }
    public int Gewicht { get; set; }

    public virtual string Toeter()
    {
        return $"{Naam} zegt toet toet";
    }
    public void ZetAan()
    {
        Aan = true;
    }
    public void ZetUit()
    {
        Aan = false;
    }

    public Voertuig(string naam)
    {
        Naam = naam;
    }

    public override string ToString()
    {
        return $"{Naam}=>\n\nmotor status: {(Aan ? "aan" : "af")}\ntop snelheid: {TopSnelheid}\ngewicht: {Gewicht}";
    }

    public override bool Equals(object? obj)
    {
        return obj is Voertuig voertuig &&
               Naam == voertuig.Naam;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Naam);
    }
}
