//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("Введите параметры задачи:");
int n = WriteNumber("Введите диапазон значений матриц: от 1 до n = ");
int a = WriteNumber("Введите число строк первой матрицы a = ");
int b = WriteNumber("Введите число столбцов первой матрицы, равное количеству строк второй матрицы b = ");
int c = WriteNumber("Введите число столбцов второй матрицы с = ");

int WriteNumber(string number)
{
    Console.Write(number);
    int outnumber = int.Parse(Console.ReadLine());
    return outnumber;
}

int[,] matrix1 = new int[a, b];
CreateArray(matrix1);
Console.WriteLine("Первая матрица:");
WriteArray(matrix1);

int[,] mattrix2 = new int[b, c];
CreateArray(mattrix2);
Console.WriteLine("Вторая матрица:");
WriteArray(mattrix2);

int[,] matrix3 = new int[a, c];

ResultMatrix(matrix1, mattrix2, matrix3);
Console.WriteLine("Произведение матриц:");
WriteArray(matrix3);

void ResultMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            int sum = 0;
            for (int f = 0; f < matrix1.GetLength(1); f++)
            {
                sum += matrix1[i, f] * matrix2[f, j];
            }
            matrix3[i, j] = sum;
        }
    }
}



void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(n);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}