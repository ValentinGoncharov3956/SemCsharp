// Напишите цикл, который 
// принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


double ReadNumber(string message)
{
        Console.WriteLine(message);
        return double.Parse(Console.ReadLine());
}

double A = ReadNumber("Введите 1 число");
double B = ReadNumber("Введите 2 число");

double C = Math.Pow(A, B);

Console.WriteLine(C);