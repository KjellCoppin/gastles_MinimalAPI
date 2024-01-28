namespace gastles_MinimalAPI_solution.Models;

public interface IVoertuig
{
    public string Naam { get; }
    public bool Aan { get; }
    public int TopSnelheid { get; set; }
    public int Gewicht { get; set; }

    public void ZetAan();
    public void ZetUit();
    public string Toeter();
}
