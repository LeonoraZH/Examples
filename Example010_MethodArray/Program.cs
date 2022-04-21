int[] array = {10, 42, 76, 32, 14, 5, 76, 17, 81};

int n = array.Length;
int find = 76;

int index = 0;

while (index < n)
{
    if(array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
    index += 1;
}