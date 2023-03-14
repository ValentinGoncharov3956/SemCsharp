// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. (номер цифры считается от левого края)

// 645 -> 5

// 78 -> третьей цифры нет

 

Console.WriteLine("Введите любое число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
userNumber1 = Math.Abs(userNumber1);

if (userNumber1 < 100 && userNumber1 > -100)
{
    Console.WriteLine ("Третьей цифры нет");
}
else
{
    // while (userNumber1 > 999 || userNumber <-999)
    // {
    // userNumber1 /= 10;
    // }

    for (; userNumber1 > 999 || userNumber1 <-999;)
    userNumber1 /= 10;

userNumber1 %= 10;
Console.WriteLine(userNumber1);
}