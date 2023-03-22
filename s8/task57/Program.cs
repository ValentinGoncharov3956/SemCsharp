// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }

// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза

// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6

// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза


// int ReadNumber(string message)
// {
//     Console.WriteLine(message);
//     return int.Parse(Console.ReadLine());
// }

int[,] GetRandomMatrix(int rows = 3, int colums = 3, int leftBorder = 0, int rightBorder = 9)
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

void PrintReapeats(int[,] matrix)
{
    int[] repeats = new int[10];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          repeats[matrix[i,j]]++;
        }
    }
    for (int i = 0; i < repeats.Length; i++)
    {
        Console.WriteLine($"{i} повторяется {repeats[i]} раз");
    }
}

int[,] myMatrix = GetRandomMatrix();
PrintMatrix(myMatrix);
Console.WriteLine();
int max = MaxNumber(myMatrix);
Console.WriteLine(max);
PrintReapeats(myMatrix);
