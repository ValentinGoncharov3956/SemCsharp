// Задача 19: Напишите программу, 
// которая принимаетна вход пятизначное 
// число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 99999)
{
    Console.WriteLine("Вы ввели неправильное число");
}
else
{
    int a = userNumber % 10;
    int b = userNumber / 10 % 10;
    int c = userNumber / 100 % 10;
    int d = userNumber / 1000 % 10;
    int e = userNumber / 10000 % 10;
    if (a == e || b == d)
    {
    Console.Write(userNumber);
    Console.WriteLine(" - Да");
    }
    else
    {
    Console.Write(userNumber);
    Console.WriteLine(" - Нет");
    }
}