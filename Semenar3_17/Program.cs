//программа принимает координаты и показывает сектор расположения этих координат

Console.WriteLine("Enter coordinates (x) ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinates (y) ");
int y = Convert.ToInt32(Console.ReadLine());

int q = getQuadrant(x, y);

if (q == 0)
    Console.WriteLine("This point is on ax");
else
{
    Console.WriteLine("This point is in quadrant # " + q);
}

int getQuadrant(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;
    else
        return 0;
}
