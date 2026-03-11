// See https://aka.ms/new-console-template for more information
namespace Task1
{ 
    class InputHandler
    {
        class StringToNumber
        {
            public StringToNumber(String input)
            {
                int parsed = int.Parse(input);
                Console.WriteLine(parsed +100);
            }
        }
        static void Main(String [] args)
        {
            Console.Write("Please, enter a number: ");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            StringToNumber processer = new StringToNumber(input);
        }
    }
}

