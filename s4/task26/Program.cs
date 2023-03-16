// Задача 26: Напишите программу, которая 
// принимает на вход число и выдаёт 
// количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadNumber(string message)
{
        Console.WriteLine(message);
        return int.Parse(Console.ReadLine());
}

int Count(int a)
{
    int count;
    for (count = 0; a != 0; count++)
  {
    a /= 10;
  }
   return count;
}

int num = ReadNumber("Введите число");
int result = Count(num);
Console.WriteLine(result);