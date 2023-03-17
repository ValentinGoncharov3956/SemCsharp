// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и 
// положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29,
// сумма отрицательных равна -20.


int ReadNumber(string message)
{
        Console.WriteLine(message);
        return int.Parse(Console.ReadLine());
}

int num = ReadNumber("Введите число");

void FillRandomArray(int[] array)
{
        for(int i=0; i < num; i++)
        {
                array[i] = Random.Shared.Next(0,2);
        }
}

int[] array = new int[num];
FillRandomArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");