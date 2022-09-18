// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int size = 4;
int[,] array = new int[size, size];

int element = 1;
int a = 0;
int b = 0;

while (element <= array.GetLength(0) * array.GetLength(1))
{
    array[a, b] = element;
    if (a <= b + 1 && a + b < array.GetLength(1) - 1)
    {
        b++;
    }
    else if (a < b && a + b >= array.GetLength(0) - 1)
    {
        a++;
    }
    else if (a >= b && a + b > array.GetLength(1) - 1)
    {
        b--;
    }
    else
    {
        a--;
    }
    element++;
}

WriteArray(array);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write($"0{array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}