// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите 1 число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 > userNumber2)
{
    Console.Write("max = ");
    Console.WriteLine(userNumber1);
    Console.Write("min = ");
    Console.WriteLine(userNumber2);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(userNumber2);
    Console.Write("min = ");
    Console.WriteLine(userNumber1);
}
