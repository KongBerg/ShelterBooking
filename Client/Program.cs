using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MongoDB.Bson;
using ShelterBooking;

namespace ShelterBooking
{
    public class Program
    {
        public static async Task Main(string[] args) //Denne k�re APP, DU D�R HVIS DU R�R DEN
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }

        static void Shelter(string[] args)
        {
            PShelter persistency = new PShelter();

            Console.WriteLine("------Get All Shelter------");
            var result = persistency.GetAll();
            
            Console.ReadKey();
        }
    }
}