// Задача 60. Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

int[,,] NewMatrix = new int[3, 3, 3];

void FillArray(int[,,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 50);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (array[i] == array[j])
                {
                    array[i] = new Random().Next(10, 50);
                    j = 0;
                }
            }
        }
    }
    int index = 0;
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            for (int m = 0; m < matrix.GetLength(2); m++)
            {
                matrix[k, l, m] = array[index];
                index++;
            }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("[");
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + " ");
            }
            Console.Write("]");
        }
        Console.WriteLine("");
    }
}

void PrintIndexArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}), ");
            }
        }
        Console.WriteLine();
    }
}

FillArray(NewMatrix);
PrintMatrix(NewMatrix);
Console.WriteLine();
PrintIndexArray(NewMatrix);