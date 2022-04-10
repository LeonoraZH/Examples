int distance = 10000;
int friendSpeed1 = 1;
int friendSpeed2 = 2;
int dogSpeed = 5;
int count = 0;
int time = 0;

string x = "к 1 другу";
string y = "к 2 другу";

string dogDirect = x;

while (distance > 10)
{
    if (dogDirect == x)
    {
        time = (distance / (friendSpeed1 + dogSpeed));
        dogDirect = y;
    }

    else
    {
        time = (distance / (friendSpeed2 + dogSpeed));
        dogDirect = x;

    }

distance -= ((friendSpeed1 + friendSpeed2) * time);
count++;

}
Console.Write("Собака встретиться с друзьями " + count + " раз.");