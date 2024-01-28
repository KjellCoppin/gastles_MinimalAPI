namespace gastles_MinimalAPI_solution.Models;

public class Boot : Voertuig
{
    public int ReddingsBoeien { get; set; }
    public int Propellors { get; set; }

    public override string Toeter()
    {
        return $"{Naam} zegt NOOOOT";
    }

    public Boot(string naam) : base(naam)
    {

    }

    public override string ToString()
    {
        return base.ToString() + $"\naantal reddings boten: {ReddingsBoeien}\naantal propellors: {Propellors}";
    }
}
