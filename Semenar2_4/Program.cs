// программа показывает кратно ли число 7 и 23

Console.WriteLine("Введите число");
int digit = Convert.ToInt32(Console.ReadLine());

if ((digit % 7 == 0) && (digit % 23 == 0))
{
    Console.WriteLine("Число " + digit + " кратно и 7 и 23");
}
else
{
    Console.WriteLine("Число " + digit + "  не кратно 7 или 23");
}