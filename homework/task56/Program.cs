// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetRandomMatrix(int rows = 4, int colums = 5, int leftBorder = 0, int rightBorder = 10)
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + ", ");
        }
        Console.WriteLine("]");
    }
}

int SumFirstLine(int[,] matrix, int i)
{
    int sumLine = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumLine += matrix[i, j];
    }
    return sumLine;
}

void Find(int[,] matrix)
{
    int index = 0;
    int sumLine = SumFirstLine(matrix, 0);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = SumFirstLine(matrix, i);
        if (sumLine > sum)
        {
            sumLine = sum;
            index = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с минимальной суммой -> {index + 1}");
}

int[,] myMatrix = GetRandomMatrix();
PrintMatrix(myMatrix);
int sumLine = SumFirstLine(myMatrix, 0);
Find(myMatrix);
