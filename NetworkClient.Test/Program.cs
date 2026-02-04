using System;
using System.Threading.Tasks;
using NetworkClient;

class Program
{
    static async Task Main()
    {
        var client = new ApiClient();

        var result = await client.GetWeatherAsync();

        Console.WriteLine("Response from server:");
        Console.WriteLine(result);

        Console.ReadLine();
    }
}
