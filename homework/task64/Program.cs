// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

uint number = 8;

void NaturalNUmber(uint n)
{
    if (n == 0) return;
    Console.Write($"{n} ");
    NaturalNUmber(n-1);
}

NaturalNUmber(number);

