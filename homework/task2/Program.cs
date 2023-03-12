// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите 1 число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int userNumber3 = Convert.ToInt32(Console.ReadLine());
int max = userNumber1;

if (userNumber2 > max) 
{
    max = userNumber2;
}
if (userNumber3 > max)
{
    max = userNumber3;
}
    Console.Write("max = ");
    Console.WriteLine(max);
