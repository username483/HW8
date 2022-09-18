// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.WriteLine("Введите размер массива AxBxC:");
int a = WriteNumber("Введите a: ");
int b = WriteNumber("Введите b: ");
int c = WriteNumber("Введите c: ");

int WriteNumber(string number)
{
  Console.Write(number);
  int outnumber = int.Parse(Console.ReadLine());
  return outnumber;
}

int[,,] array = new int[a, b, c];

FillArray(array);
PrintArray(array);



void FillArray(int[,,] array)
{
  int[] outputArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  temp;
  for (int i = 0; i < outputArray.GetLength(0); i++)
  {
    outputArray[i] = new Random().Next(10, 100);
    temp = outputArray[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (outputArray[i] == outputArray[j])
        {
          outputArray[i] = new Random().Next(10, 100);
          j = 0;
          temp = outputArray[i];
        }
          temp = outputArray[i];
      }
    }
  }

  int count = 0; 
  for (int a = 0; a < array.GetLength(0); a++)
  {
    for (int b = 0; b < array.GetLength(1); b++)
    {
      for (int c = 0; c < array.GetLength(2); c++)
      {
        array[a, b, c] = outputArray[count];
        count++;
      }
    }
  }
}

void PrintArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"a({i}) b({j}) ");
      for (int f = 0; f < array.GetLength(2); f++)
      {
        Console.Write( $"c({f})={array[i,j,f]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}