namespace Class03_Exersice6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number1");
            string number1input = Console.ReadLine();
            int number1;

            bool number1Success = int.TryParse(number1input, out number1);

            if (!number1Success)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Number2");
            string number2input = Console.ReadLine();
            int number2;

            bool number2Success = int.TryParse(number2input, out number2);

            if (!number2Success)
            {
                Console.WriteLine("Wrong input");
                return;
            }
            int largeNum;

            if (number1 > number2)
            {
                largeNum = number1;
                Console.WriteLine($"{number1input} is bigger than {number2input}");
            }
            else if (number2 > number1)
            {
                largeNum = number2;
                Console.WriteLine($"{number2input} is bigger than {number1input}");
            }
            else
            {
                largeNum = number2;
                Console.WriteLine($"{number1input} and {number2input} are equal");
            }

            if (number1 % 2 == 0)
            {
                Console.WriteLine($"NUmber {number1} is even");
            }
            else
            {
                Console.WriteLine($"NUmber {number1} is  odd");
            }

            if (number2 % 2 == 0)
            {
                Console.WriteLine($"NUmber {number2} is even");
            }
            else
            {
                Console.WriteLine($"NUmber  {number2} is odd");
            }

            if (largeNum % 2 == 0)
            {
                Console.WriteLine($"The bigger number {largeNum} is even");
            }
            else
            {
                Console.WriteLine($"The bigger number  {largeNum} is odd");
            }
        }
    }
}