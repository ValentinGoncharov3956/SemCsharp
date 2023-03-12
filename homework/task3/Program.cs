// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите 1 число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 % 2 == 0) 
{
    Console.Write(userNumber1);
    Console.Write(" - да");
}
else 
{
    Console.Write(userNumber1);
    Console.Write(" - нет");
}