// See https://aka.ms/new-console-template for more information
namespace Task1
{ 
    class InputHandler
    {
        class StringToNumber
        {
            int number;
            public StringToNumber(String input)
            {
                number = int.Parse(input);
                Console.WriteLine(number + 100);
            }
            public int returnNumber()
            {
                return number;
            }
        }
        public int calculateAverage(int input1, int input2)
        {
            var average = (input1 + input2) / 2;
            return average;
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

