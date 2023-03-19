// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса нечётные, 
// и замените эти элементы на их квадраты.

// Например, изначально массив                              
//  выглядел вот так:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4



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

void PrintNewMatrix(int[,] matrix)
{    
    for (int i = 1; i < matrix.GetLength(0); i = i + 2)
    {
        for (int j = 1; j < matrix.GetLength(1); j = j + 2)
        { 
            matrix[i,j] = matrix[i,j] * matrix[i,j];
        }
    }
}

int m = ReadNumber("Введите количетсво строк");
int n = ReadNumber("Введите количетсво столбцов");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
Console.WriteLine();
PrintNewMatrix(myMatrix);
PrintMatrix(myMatrix);