//принимает на входе два числа и выводит, является ли первое кратным второму

Console.WriteLine("Введите первое число");
int digit1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int digit2 = Convert.ToInt32(Console.ReadLine());

if (digit1 % digit2 == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
    Console.WriteLine("Первое число не кратно второму");
    Console.WriteLine("Остаток от деления = " + (digit1 % digit2));
}

