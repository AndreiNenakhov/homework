// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write (" Введите количество строк в массиве ");
int rows = int.Parse (Console.ReadLine());
Console.Write (" Введите количество столбцов в массиве ");
int colums = int.Parse (Console.ReadLine ());
int [,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);

Console.WriteLine ($"Строка с наименьшей суммой - {GetRowNumbers (array)}");

int [,] GetArray(int m, int n, int min, int max)
{
    int [,] result = new int [m, n];
    for (int i = 1; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetRowNumbers (int [,] array)
{
    int row = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0, i];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];

        }
        if (minSum > sum)
        {
            minSum = sum;
            row = i;
        }
    }
   return row;
}

void WriteArray (int[,] array)
{
  for    (int i=0;   i < array.GetLength(0); i++)
  {
    for    (int j=0;   j<array.GetLength(1); j++)
    {
      Console.Write(array [i, j] + " ");
    }
    Console.WriteLine();
  }
}
        
