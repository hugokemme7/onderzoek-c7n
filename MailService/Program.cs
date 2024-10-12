using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("This is an unstable mail service!");
        
        while (true)
        {
            await Task.Delay(5000);  // Simulate doing work every second
            Console.WriteLine("Still running...");
        }
    }
}
