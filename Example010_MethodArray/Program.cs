using static System.Console;
Clear();

int[] array = {1, 5, 24, 19, 15, 32, 11, 24};

int n = array.Length;
int find = 24;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        WriteLine(index);
        break;
    }

index++;    
}
