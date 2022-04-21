
Console.Write("Enter quadrant : ");
int quadrant = Convert.ToInt32(Console.ReadLine());

string coord = coordinates(quadrant);


Console.Write(coord);


string coordinates(int quad)
{
    if (quad == 1)
        return "x > 0, y > 0";
    if (quad == 2)
        return "x < 0, y > 0";
    if (quad == 3)
        return "x < 0, y < 0";
    if (quad == 4)
        return "x > 0, y < 0";
    else
        return "Invalid Data itered";
}