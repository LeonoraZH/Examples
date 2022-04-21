using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число :");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Квадрат числа :");
            Console.WriteLine(number * number);
        }
    }

}