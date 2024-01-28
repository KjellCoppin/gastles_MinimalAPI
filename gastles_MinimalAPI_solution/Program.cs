using gastles_MinimalAPI_solution.Models;

namespace gastles_MinimalAPI_solution;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        IGarage _garage = Garage.Instance;

        app.MapGet("/", () => "Hello world!");

        app.MapGet("/voertuigen", () => _garage.Voertuigen);
        app.MapGet("/voertuigen/{naam}", (string naam) => _garage.VerkrijgVoertuig(naam));
        app.MapGet("/voertuigen/{naam}/toeter", (string naam) => _garage.VerkrijgVoertuig(naam).Toeter());

        app.MapPost("/voertuigen/auto", (Auto auto) => _garage.VoertuigToevoegen(auto));
        app.MapPost("/voertuigen/motor", (Motor motor) => _garage.VoertuigToevoegen(motor));
        app.MapPost("/voertuigen/boot", (Boot boot) => _garage.VoertuigToevoegen(boot));

        app.Run();
    }
}