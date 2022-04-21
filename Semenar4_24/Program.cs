// принимает на вход число N и выдает сумму чисел от 1 до N
int number;

Console.WriteLine("Please, enter positive integer number : ");
while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
{
    Console.WriteLine("Wrong input, try again");
    Console.Write("Please, enter positive integer number: ");
}
int sum = 0;
for (int i = 1; i <= number; i++)
{
    sum += i;
}
Console.WriteLine("Sum of all numbers from 1 to " + number + " equals " + sum);
