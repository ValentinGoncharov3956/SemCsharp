// Задача 35: Задайте одномерный массив из 123 
// случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в 
// отрезке [10,99]. 

// Пример для массива из 5, а не 123 
// элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int ReadNumber(string message)
{
        Console.WriteLine(message);
        return int.Parse(Console.ReadLine());
}
int lenght = 123;
void RandomArray(int[] array)
{
        for(int i=0; i < lenght; i++)
        {
                array[i] = Random.Shared.Next(1, 1000);
        }
}

int SumArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
       if (array[i] > 10 && array[i] < 100)
       count = count + 1; 
    }
    return count;
}

int[] array = new int[lenght];
RandomArray(array);
int sum = SumArray(array);
Console.WriteLine($"[{string.Join(", ", array)}] -> {sum}");
