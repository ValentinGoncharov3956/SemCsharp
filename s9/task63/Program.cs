// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

uint number = 5;

void NaturalNUmber(uint n)
{
    if (n > 1)
    {
        NaturalNUmber(n-1);
    }
    Console.Write($"{n}, ");
}

NaturalNUmber(number);

