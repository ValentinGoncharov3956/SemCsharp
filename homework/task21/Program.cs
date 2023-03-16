// Задача 21: Напишите программу, 
// которая принимает на вход координаты 
// двух точек и находит расстояние между 
// ними в 3D пространстве.


// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double ReadNumber(string message)
{
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
}

double x1 = ReadNumber("Введите координату точки A по X");
double y1 = ReadNumber("Введите координату точки A по Y");
double z1 = ReadNumber("Введите координату точки A по Z");
double x2 = ReadNumber("Введите координату точки B по X");
double y2 = ReadNumber("Введите координату точки B по Y");
double z2 = ReadNumber("Введите координату точки B по Z");

double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"{res:f2}");   // f2 сокращает до дестяков 5.2151655 -> 5.21