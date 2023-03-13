// Напишите программу, которая принимает 
// на вход число и проверяет, кратно ли 
// оно одновременно 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 % 7 == 0 && userNumber1 % 23 == 0)
{
    Console.WriteLine($"{userNumber1} - да");
}
else  
{
    Console.WriteLine($"{userNumber1} - нет");
}