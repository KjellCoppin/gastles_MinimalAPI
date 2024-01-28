using gastles_MinimalAPI_solution.Models;

namespace gastles_MinimalAPI_solution;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        // IGarage _garage = Garage.Instance;

        app.MapGet("/", () => "Hello world!");


        app.Run();
    }
}