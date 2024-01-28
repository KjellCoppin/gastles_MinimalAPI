namespace gastles_MinimalAPI_solution.Models
{
    //public sealed class Garage : IGarage
    //{
    //    public static Garage Instance { get; } = new();
    //    private Garage() { }

    //    public ICollection<IVoertuig> Voertuigen { get; } = new List<IVoertuig>();

    //    public IVoertuig VerkrijgVoertuig(string naam)
    //    {
    //        return Voertuigen.First(v => v.Naam == naam);
    //    }

    //    public ICollection<Auto> VerkrijgAutos()
    //    {
    //        return Voertuigen.Where(v => v.GetType() == typeof(Auto)).Select(v => (Auto)v).ToList();
    //    }

    //    public ICollection<Boot> VerkrijgBoten()
    //    {
    //        return Voertuigen.Where(v => v.GetType() == typeof(Boot)).Select(v => (Boot)v).ToList();
    //    }

    //    public ICollection<Motor> VerkrijgMotors()
    //    {
    //        return Voertuigen.Where(v => v.GetType() == typeof(Motor)).Select(v => (Motor)v).ToList();
    //    }

    //    public IVoertuig VoertuigToevoegen(IVoertuig voertuig)
    //    {
    //        Voertuigen.Add(voertuig);
    //        return voertuig;
    //    }

    //    public IVoertuig VoertuigVerwijderen(string naam)
    //    {
    //        IVoertuig voertuig = Voertuigen.First(v => v.Naam.Equals(naam));

    //        Voertuigen.Remove(voertuig);
    //        return voertuig;
    //    }
    //}
}
