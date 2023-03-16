// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]


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
        Console.Write(array[i] + " ");
}
