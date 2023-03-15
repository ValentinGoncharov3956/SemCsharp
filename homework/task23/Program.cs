
// // Задача 23: Напишите программу, 
// которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 4, 9. 
// // 5 -> 1, 8, 27, 64, 125

// // 3 -> 1, 8, 27 
// // 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int index =1;

while (index <= n)
{
    double a = Math.Pow(index, 3);
    index++;
    Console.WriteLine(a);
}
