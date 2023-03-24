// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


int[,] GetRandomMatrix(int rows = 4, int colums = 4, int leftBorder = 1, int rightBorder = 10)
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

void Multiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] array = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = matrix1[i, j] * matrix2[i, j];
            Console.Write(array[i, j] + ", ");
        }
        Console.WriteLine("]");
    }
}

int[,] myMatrix = GetRandomMatrix();
int[,] newMatrix = GetRandomMatrix();
PrintMatrix(myMatrix);
Console.WriteLine();
PrintMatrix(newMatrix);
Console.WriteLine();
Console.WriteLine($"Их произведение будет равно следующему массиву:");
Console.WriteLine();
Multiplication(myMatrix, newMatrix);