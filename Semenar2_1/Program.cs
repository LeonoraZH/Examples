// для случайного числа в диапазоне 10-99 вывести его наибольшую цифру

int n = new Random().Next(10, 100);

int digit1 =  n % 10;
int digit2 = n / 10;

if (digit1 > digit2)
{
    Console.WriteLine("Для числа " + n + " наибоьшая цифра " + digit1);
}
else
{
    Console.WriteLine("Для числа " + n + " наибоьшая цифра " + digit2);
}