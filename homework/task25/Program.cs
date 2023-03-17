// Напишите цикл, который 
// принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int ReadNumber(string message)
{
        Console.WriteLine(message);
        return int.Parse(Console.ReadLine());
}


int Pow(int A, int B)
{
    int c = 1;
    for (int i = 0; i < B; i++)
    {
        c = A * c;
    }
    return c;
}
// double C = Math.Pow(A, B);

bool Rest(int B)
    {
        if (B < 0)
        {
            Console.WriteLine ("Укажите другое число");
            return false;
        }
        return true;
    }


int A = ReadNumber("Введите 1 число");
int B = ReadNumber("Введите 2 число");
if (Rest(B))
{
Console.WriteLine(Pow(A, B));
}