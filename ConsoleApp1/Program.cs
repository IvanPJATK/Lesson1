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
        public int calculateAverage(int[] values)
        {
            var average = 0;
            for(int i = 0; i < values.Length; i++)
            {
                average += values[i];
            }
            return average/values.Length;
        }
        public int CalculateMax(int[] values)
        {
            var max = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > max) { max = values[i]; }
            }
            return max;
        }

        public int CalculateMin(int[] values)
        {
            var min = values[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < min) { min = values[i]; }
            }
            return min;
        }
        static void Main(String [] args)
        {
            Console.Write("Please, enter first number: ");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            Console.Write("Please, enter second number: ");
            string input2 = Console.ReadLine();
            Console.WriteLine(input2);
            StringToNumber processer = new StringToNumber(input);
            StringToNumber processer2 = new StringToNumber(input2);
            InputHandler handler = new InputHandler();
            var average = handler.calculateAverage(processer.returnNumber(), processer2.returnNumber());
            Console.WriteLine(average);
        }
    }
}

