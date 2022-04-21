Console.Write("Введите число :");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число :");
int number2 = Convert.ToInt32(Console.ReadLine());

if ((number1 * number1) == number2)
{
    Console.Write("Это квадрат числа");
}
else
{
    Console.Write("Это НЕ квадрат числа");
}