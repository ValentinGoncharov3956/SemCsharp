// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

uint M = 3;
uint N = 3;

uint FunctionAckermann(uint m, uint n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return FunctionAckermann(m - 1, 1);
    if (m > 0 && n > 0) return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
    return FunctionAckermann(m,n);
}

uint Function = FunctionAckermann(M, N);
Console.WriteLine(Function);
