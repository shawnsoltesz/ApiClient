using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ConsoleTables;

namespace ApiClient
{
    class Program
    {

        static async Task Main(string[] args)
        {
            var client = new HttpClient();

            var todayDate = DateTime.Now;

            //var responseBodyAsStream = await client.GetStreamAsync("https://official-joke-api.appspot.com/random_joke");

            //var items = await JsonSerializer.DeserializeAsync<List<Item>>(responseBodyAsStream);

            var responseBodyAsStream10 = await client.GetStreamAsync("https://official-joke-api.appspot.com/random_ten");

            var items = await JsonSerializer.DeserializeAsync<List<Item>>(responseBodyAsStream10);
            //var table = new ConsoleTable("Joke", "Punchline");
            Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.WriteLine("                            Jokes of the Day\n");
            Console.WriteLine($"                     Today is {todayDate}\n");
            Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n\n");

            foreach (var item in items)
            {
                //table.AddRow(item.Setup, item.Punchline);
                Console.WriteLine($"{item.Setup}\n");
                Console.WriteLine($"Punchline: {item.Punchline}\n\n");
            }
            //table.Write();
        }
    }
}
