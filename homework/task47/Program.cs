﻿// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

double[,] GetRandomMatrix(int rows, int colums)
{
    double[,] matrix = new double[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.NextDouble() * 10 - 5;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(" {0,5:F2} ", matrix[i, j]);
        }
        Console.WriteLine("]");
    }
}

while (true)
{
    int m = ReadNumber("Введите количетсво строк");
    int n = ReadNumber("Введите количетсво столбцов");

    if (n > 0 && m > 0)
    {
        double[,] myMatix = GetRandomMatrix(m, n);
        PrintMatrix(myMatix);
        break;
    }
    else
    {
        Console.WriteLine("Значения не могут быть отрицательными.");
        Console.WriteLine("Введите положительные числа.");
    }
}

