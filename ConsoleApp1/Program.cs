// See https://aka.ms/new-console-template for more information
namespace Task1
{ 
    class InputHandler
    {
        static void Main(String [] args)
        {
            Console.Write("Please, enter a number: ");
            string input = Console.ReadLine();
            Console.WriteLine(input);
        }
    }
}

