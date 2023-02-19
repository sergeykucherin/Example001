// Поиск элемента массива, созданного генератором случайных чисел, с помощью метода (если позиция не найдена, то отобразиться -1)

using static System.Console;
Clear();

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random() .Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        WriteLine(col[position] );
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
array[4] = 5;
array[6] = 5;
PrintArray(array);
WriteLine();

int pos = IndexOf(array, 444);
WriteLine(pos);








