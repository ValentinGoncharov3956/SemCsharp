// Задача 28: Напишите программу, 
// которая принимает на вход число 
// N и выдаёт произведение чисел от 1 до N.

// 4 -> 24 
// 5 -> 120

int ReadNumber(string message)
{
        Console.WriteLine(message);
        return int.Parse(Console.ReadLine());
}

int SumToA(int a)
{
    int sum = 1;
    for(int i = 1; i <= a; i++)
    {
        sum = sum * i;
    }
    return sum;
}

int num = ReadNumber("Введите число");
int result = SumToA(num);
Console.WriteLine(result);