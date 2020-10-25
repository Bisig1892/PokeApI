using PokeApiCore;
using System;
using System.Threading.Tasks;

namespace PokeApiConsole
{
    class Program
    {
        static async Task Main()
        {
            PokeApiClient client = new PokeApiClient();
            Pokemon result = await client.GetPokemonByName("charmander");
            
            Console.WriteLine($"Pokemon Id: {result.id}" +
                $"\nName: {result.name}" +
                $"\nHeight(inches): {result.height}" +
                $"\nWeight: {result.weight}");
            Console.ReadKey();
        }
    }
}
