﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= userNumber1; i++)                              // если условия, как в задаче на семинаре, то вместо 1 поставить -userNumber1
{
    if (i % 2 == 0) 
    Console.WriteLine(i + " ");
}
