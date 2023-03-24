// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7

int[,] GetRandomMatrix(int rows = 4, int colums = 4)
{
    int[,] matrix = new int[rows, colums];

    int number = 1;
    int i = 0;
    int j = 0;
    while (number <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = number;
        number++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else 
        if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else 
        if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
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

int[,] myMatrix = GetRandomMatrix();
PrintMatrix(myMatrix);
