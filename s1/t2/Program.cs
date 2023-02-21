// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет


Console.WriteLine("Введите 1 число");
string userAnswer1 = Console.ReadLine();
int userNumber1 = Convert.ToInt32(userAnswer1);
Console.WriteLine("Введите 2 число");
string userAnswer2 = Console.ReadLine();
int userNumber2 = Convert.ToInt32(userAnswer2);

if (userNumber1 == userNumber2 * userNumber2)
{
    Console.WriteLine("Да");
}
else 
Console.WriteLine("Нет");