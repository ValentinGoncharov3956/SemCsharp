// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int ReadNumber(string message)
// {
//         Console.WriteLine(message);
//         return int.Parse(Console.ReadLine());
// }
int lenght = 10;
void RandomArray(int[] array)
{
        for(int i=0; i < lenght; i++)
        {
                array[i] = Random.Shared.Next(100,1000);
        }
}

int SumPosArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
       if (array[i] % 2 == 0)
       count = count + 1; 
    }
    return count;
}

int[] array = new int[lenght];
RandomArray(array);
int sum = SumPosArray(array);
Console.WriteLine($"[{string.Join(", ", array)}] -> {sum}");
