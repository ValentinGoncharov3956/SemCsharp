// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на
//  главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int colums, int leftBorder = 0, int rightBorder = 10)
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

int Sum(int[,] matrix)
{
    int Sum = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        Sum += matrix[i, i];
    }
return Sum;
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


int m = ReadNumber("Введите количетсво строк");
int n = ReadNumber("Введите количетсво столбцов");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
int sum = Sum(myMatrix);
Console.WriteLine($"Сумма чисел главной диагонали: {sum}");