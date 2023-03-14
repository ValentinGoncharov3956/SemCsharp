// Напишите программу, 
// которая принимает на 
// вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.

// 5 -> 1, 8, 27, 64, 125.
// 2 -> 1, 8

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int index =1;

while (index <= n)
{
    double a = Math.Pow(index, 3);
    index++;
    Console.WriteLine(a);
}
