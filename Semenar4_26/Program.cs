// программа принимает на вход число и выдает количестко цифр в числе
int number;
Console.Write("Please, enter number : ");
while(!int.TryParse(Console.ReadLine(), out number) || number < 0)
{
    Console.WriteLine("Wrong input, try again");
    Console.WriteLine("Please, enter number : ");
}
//string str = Convert.ToString(number);
//int len = str.Length;
//Console.WriteLine(len);
// можно еще делить на 10 и каждый раз i++
int count = 1;
while (number > 10)
{
    number /= 10;
    count++;
}
Console.WriteLine(count);