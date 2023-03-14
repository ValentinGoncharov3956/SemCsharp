// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница


Console.WriteLine("Введите число от 1 до 7");
// string userAnswer1 = Console.ReadLine();
// int userNumber1 = Convert.ToInt32(userAnswer1);
int userNumber1 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 == 1)
{
    Console.WriteLine("Понедельник");
}
else
if (userNumber1 == 2)
{
    Console.WriteLine("Вторник");
}
else
if (userNumber1 == 3)
{
    Console.WriteLine("Среда");
}
else
if (userNumber1 == 4)
{
    Console.WriteLine("Четверг");
}
else
if (userNumber1 == 5)
{
    Console.WriteLine("УРААААА!!!! Пятница");
}
else
if (userNumber1 == 6)
{
    Console.WriteLine("Суббота");
}
else
if (userNumber1 == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Ты неправильно выполнил условие:(");
}