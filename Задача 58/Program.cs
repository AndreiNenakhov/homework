﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//  Например, даны 2 матрицы:
//  2 4 | 3 4
//  3 2 | 3 3
//  Результирующая матрица будет:
//  18 20
//  15 18


int [,] GetArray = new int (int rows, int columns)
{
    int[,] array = new int [rows, int columns];
    for (int i = 0; i < rows; i++)
    {
        for (j = 0; j < columns; j++)
        {
            array [i, j] = new Random().Next(1, 10);
        }
    }
    return array; 
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for  (int j = 0; j < array.GetLength(1); ++j)
        {
            Console.Write(array[i, j] + " " );
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
