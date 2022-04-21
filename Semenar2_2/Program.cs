// рандомно выбирае 3х значное число и из 1 и 3 создает двухзначное

int n = new Random().Next(100, 1000);
Console.WriteLine(n);
int digit1 =  n / 100;
int digit2 = n % 10;
int m = digit1 * 10;



Console.WriteLine(m + digit2);
