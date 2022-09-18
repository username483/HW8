// Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.Write("Введите количество строк m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FindNewArray(matrix);
PrintArray(matrix);

void FindNewArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int f = 0; f < matrix.GetLength(1) - 1; f++)
            {
                
                if (matrix[i, f + 1] > matrix[i, f])
                {
                    int number = matrix[i, f + 1];
                    matrix[i, f + 1] = matrix[i, f];
                    matrix[i, f] = number;
                }

            }
        }
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 это количество строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 это количество столбцов
        {
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}



