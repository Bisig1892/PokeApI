using PokeApiCore;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokeApiConsole
{
    class Program
    {
        static async Task Main()
        {
            try
            {
                PokeApiClient client = new PokeApiClient();
                Pokemon result = await client.GetPokemonByName("charmander");

                Console.WriteLine($"Pokemon Id: {result.id}" +
                    $"\nName: {result.name}" +
                    $"\nHeight(inches): {result.height}" +
                    $"\nWeight: {result.weight}");
            }
            catch(ArgumentException)
            {
                Console.WriteLine("I'm sorry, that Pokemon does not exist");
            }
            catch(HttpRequestException)
            {
                Console.WriteLine("Please try again later.");
            }
            Console.ReadKey();
        }
    }
}
