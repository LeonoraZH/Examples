

int number;
Console.WriteLine("Please, enter positive integer number : ");
while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
{
    Console.WriteLine("Wrong input, try again");
    Console.WriteLine("Please, enter positive integer number : ");
}
int mult = 1;
for (int i = 1 ; i <= number; i++)
{
    mult *= i;
}
Console.WriteLine("Multiplication of all numbers from 1 to " + number + " equals " + mult);