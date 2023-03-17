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

int num = ReadNumber("Введите кол-во эл массива");

int[] Array = new int[num];

for(int i = 0; i < Array.Length; i++)
{
        Array[i] = ReadNumber($"Введите число для массива с индексом {i}");
}

Console.WriteLine("Вывод массива:");
Console.Write("[ ");
for(int i = 0; i < Array.Length; i++)
{
        Console.Write($"{Array[i]} ");
}
Console.WriteLine("]");