// Задача 46: Задайте двумерный массив 
// размером m×n, заполненный случайными целыми числами.

// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

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
int[,] myMatix = GetRandomMatrix(m, n);
PrintMatrix(myMatix);
