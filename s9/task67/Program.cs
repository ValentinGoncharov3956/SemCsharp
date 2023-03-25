// Задача 67: Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9

int number = 453;

int Vozvrat(int n)
{   
    int sum = 0;
    sum = n % 10;
    if(n>10)
    {
        sum += Vozvrat(n / 10);
    }
    return sum;
}

int a = Vozvrat(number);
System.Console.WriteLine(a);