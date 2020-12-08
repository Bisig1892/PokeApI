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
            PokeApiClient client = new PokeApiClient();
            try
            {
                // Pokemon result = await client.GetPokemonByName("charmander");
                Pokemon result = await client.GetPokemonById(1);

                Console.WriteLine($"Pokemon Id: {result.id}" +
                    $"\nName: {result.Name}" +
                    $"\nHeight(inches): {result.Height}" +
                    $"\nWeight: {result.Weight}");
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
