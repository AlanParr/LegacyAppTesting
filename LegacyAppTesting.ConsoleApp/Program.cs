using System;
using System.Threading.Tasks;

namespace LegacyAppTesting.ConsoleApp
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            //Instantiate bored client.
            var service = new BoredomSuggestionService();
            Console.WriteLine("Bored? Would you like a suggestion for something to do? (Y/N): ");
            while (Console.ReadLine() == "Y")
            {
                var randomActivity = await service.FindSomethingToDo();
                Console.WriteLine("  How about " + randomActivity.Activity + "?");
                Console.WriteLine("");
                Console.WriteLine("Still bored?");
            }
                
            Console.WriteLine("So glad you're not bored any more, enjoy your activity!");
        }
    }
}