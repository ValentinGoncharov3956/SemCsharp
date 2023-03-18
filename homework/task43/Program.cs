// Задача 43. Напишите программу, которая найдёт координату 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadNumber(string message)
{
        Console.WriteLine(message);
        return double.Parse(Console.ReadLine());
}

double b1 = ReadNumber("Введите первую координату по X");
double k1 = ReadNumber("Введите вторую координату по X");
double b2 = ReadNumber("Введите первую координату по Y");
double k2 = ReadNumber("Введите вторую координату по Y");

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");