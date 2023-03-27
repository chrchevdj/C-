namespace Class03.Exe05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] ints = new int[5];
            for (int i = 0; i < ints.Length; i++) 
            { 
                Console.Write("Enter the number ", i);
                ints[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach (int i in ints)
            {
                sum += i;
            }
            Console.WriteLine($"the sum of the five numbers is {sum}");
        }
    }
}