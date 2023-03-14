// Задача 10: Напишите программу, которая принимает на 
//вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите любое трёхзначное число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 < 100 || userNumber1 > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число.");
}
else
{
    Console.WriteLine(userNumber1 / 10 % 10);
}