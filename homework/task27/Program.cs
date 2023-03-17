// Задача 27: Напишите программу, 
// которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12



int ReadNumber(string message)
{
        Console.WriteLine(message);
        return int.Parse(Console.ReadLine());
}

int Count(int a)
{
  int sum = 0;
  while (a > 0)
  {
    sum = sum + a % 10;
    a = a / 10;
  }
  return sum;
}

int num = ReadNumber("Введите число");
Console.WriteLine(Count(num));