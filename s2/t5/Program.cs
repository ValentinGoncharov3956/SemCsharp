// Напишите программу, которая принимает 
// на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


Console.WriteLine("Введите 1 число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 == userNumber2 * userNumber2  || userNumber2 == userNumber1 * userNumber1)
{
    Console.WriteLine("да");
}
else
    Console.WriteLine("нет");