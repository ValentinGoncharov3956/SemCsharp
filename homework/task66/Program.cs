// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 1;
int N = 15;

int SumNumber(int first, int end)
{
    if(end == first) return first;
    return end + SumNumber(first, end-1);
}

int sum = SumNumber(M,N);
Console.WriteLine(sum);
