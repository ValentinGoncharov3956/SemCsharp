// Вычислить факториал введеного числа N
// 4 -> 24
// 5 -> 120

uint number = 4;

uint Factorial(uint n)
{
    if (n < 0) throw new Exception($"Неверно введено число{n}");
    if (n ==0) return 1;
    if (n == 1) return 1;
    return n * Factorial(n - 1);     // 4! = 4*3!, 3! = 3*2!, 2! = 2*1!, 1!=1
    //return result;                          // 1, 2*3=6, 6*4=24;
}

Console.WriteLine(Factorial(number));
