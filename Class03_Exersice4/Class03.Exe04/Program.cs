namespace Class03.Exe04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] wordsarray = { "Djoko", "Chrchev" };
            foreach (string word in wordsarray)
            {
                Console.WriteLine(word);
            }
            decimal[] decimalarray = { 1.00m, 2.00m };
            foreach (decimal dec in decimalarray)
            {
                Console.WriteLine(dec);
            }
            Console.WriteLine(decimalarray);
            char[] chararray = { 'A', 'B' };
            Console.WriteLine(chararray);
            bool[] boolarray = { true, false };
            Console.WriteLine(boolarray);
            int[][] intarr = { new int[] { 1, 2 }, new int[] { 3, 4 } };
            Console.WriteLine(intarr);

        }
        

    }
}
