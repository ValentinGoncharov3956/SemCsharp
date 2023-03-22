// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по возрастанию 
//элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8

int[,] GetRandomMatrix(int rows = 3, int colums = 10, int leftBorder = 0, int rightBorder = 10)
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

void NewMatrix(int[,] matrix)
{
    for (int k = 1; k < matrix.GetLength(1); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] > matrix[i, j + 1])       // если знак (<) меняем на сортировку по убыванию 
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }
    }
}


int[,] myMatrix = GetRandomMatrix();
PrintMatrix(myMatrix);
NewMatrix(myMatrix);
Console.WriteLine("Новый массив:");
PrintMatrix(myMatrix);