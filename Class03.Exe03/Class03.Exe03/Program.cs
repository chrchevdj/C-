Console.WriteLine("Please enter the number:");

string inputNumberOne = Console.ReadLine();
int numberOne;

bool numberOneSuccessParse = int.TryParse(inputNumberOne, out numberOne);

if (!numberOneSuccessParse)
{
    Console.WriteLine("Wrong input");
    return;
}
int counter = 0;
for (int i = 1; i < numberOne; i++)
{
    if (i % 3 != 0 && i % 7 != 0)
    {
    counter--;
    Console.WriteLine($"Message no. {i}");
    }
    if (i == 100) 
    {
    Console.WriteLine("The limit is reached");
    break;
    }
  }

Console.ReadKey();
