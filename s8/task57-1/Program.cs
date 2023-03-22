
int[,] GetRandomMatrix(int rows = 5, int colums = 5, int leftBorder = 0, int rightBorder = 25)
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

int MaxNumber(int[,] matrix)
{
    int max = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (max < matrix[i, j])
            {
                max = matrix[i, j];
            }
        }
    }
    return max;
}

void PrintReapeats(int[,] matrix, int MaxNumber)
{
    for (int k = 0; k <= MaxNumber; k++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == k)
                {
                    sum += 1;
                }
            }
        }
        Console.WriteLine($"{k} повторяется {sum} раз");
    }
}

int[,] myMatrix = GetRandomMatrix();
PrintMatrix(myMatrix);
Console.WriteLine();
int max = MaxNumber(myMatrix);
Console.WriteLine($"Максимальное число в массиве -> {max}");
Console.WriteLine();
PrintReapeats(myMatrix, max);