// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Введите количество строк (равное количеству столбцов) m: ");
int m = int.Parse(Console.ReadLine());

int[,] matrix = new int[m, m];

FillArray(matrix);
PrintArray(matrix);

int minSumRow = 0;
int RowSum = CountSumRow(matrix, 0);

for (int i = 1; i < matrix.GetLength(0); i++)
{
  int temp = CountSumRow(matrix, i);
  if (RowSum > temp)
  {
    RowSum = temp;
    minSumRow = i;
  }
}

Console.WriteLine($"\n{minSumRow+1} - строкa с наименьшей суммой элементов, Сумма = {RowSum}");


int CountSumRow(int[,] array, int i)
{
  int RowSumElements = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    RowSumElements += array[i,j];
  }
  return RowSumElements;
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



