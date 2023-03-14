// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите день недели ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 > 5 && userNumber1 <=7)
{
    Console.WriteLine ("УРАААААААААА, ВЫХОДНЫЫЫЫЫЕ!!!");
}
    else
        {
        if (userNumber1 > 0 && userNumber1 <= 5 )
        {
            Console.WriteLine("ОПЯТЬ НА РАБОТУ:((");
        }
        else
            Console.WriteLine("ТЫ ДУРАК ЧТОЛЕ? ДЕНЬ НЕДЕЛИ СПРАШИВАЮ! ТАКОГО ДНЯ НЕТ!");
        }