// Задача 50: Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows = 5, int colums = 5, int leftBorder = 0, int rightBorder = 10)
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

void Checking(int[,] matrix, int rows, int colums)
{
    if (rows > matrix.GetLength(0) || colums > matrix.GetLength(1))
    {
        Console.WriteLine($"{rows}, {colums} - > Вы вышли за пределы масива.");
    }
    else
    {
    Console.WriteLine($"{matrix[rows, colums]}");
    }
}

int[,] myMatrix = GetRandomMatrix();
PrintMatrix(myMatrix);
System.Console.WriteLine();
Console.WriteLine("Введите искомое число");
int m = ReadNumber("Введите строку");
int n = ReadNumber("Введите столбец");
Checking(myMatrix, m, n);

