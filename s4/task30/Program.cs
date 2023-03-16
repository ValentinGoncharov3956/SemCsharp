// Задача 30: Напишите программу, 
// которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]


int ReadNumber(string message)
{
        Console.WriteLine(message);
        return int.Parse(Console.ReadLine());
}

int num = ReadNumber("Введите число");

int[] array = new int[num];

for(int i=0; i < num; i++)
{
        array[i] = Random.Shared.Next(0,2);
}

Console.WriteLine(string.Join(" ", array));
