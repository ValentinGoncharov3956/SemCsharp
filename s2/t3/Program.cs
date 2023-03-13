// Напишите программу, которая будет принимать на вход 
// два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


Console.WriteLine("Введите 1 число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
int res = userNumber1 % 10;
if (userNumber1 % userNumber2 == 0)
{
    Console.WriteLine("кратно");
}
else
{ Console.Write("не кратно, остоток ");
    Console.WriteLine(res);
}