// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница


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