// Напишите программу, 
// которая по заданному номеру четверти, 
// показывает диапазон возможных координат 
// точек в этой четверти (x и y).

double ReadNumber(string message)
{
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
}

double x1 = ReadNumber("Введите координату точки по X1");
double y1 = ReadNumber("Введите координату точки по Y1");
double x2 = ReadNumber("Введите координату точки по X2");
double y2 = ReadNumber("Введите координату точки по Y2");


//         Console.WriteLine(message);
//         int value = Convert.ToInt32(Console.ReadLine());
//         return value;

