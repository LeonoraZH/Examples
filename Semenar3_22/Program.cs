// принимает на вход число N и выдает таблицу квадратов от 1 до N
// 5 -> 1, 4, 9, 16, 25

Console.Write("Enter digit : ");
int digit = Convert.ToInt32(Console.ReadLine());

Digit(digit);

void Digit(int N)
{
    int count = 1;
    int square = 0;
    while (count <= N)
    {
        square = count * count;
        Console.Write(square + "  ");
        count++;
    }
}

//  либо int square(int n)
//          return n * n