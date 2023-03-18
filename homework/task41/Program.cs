// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int ReadNumber(string message)
{
        Console.WriteLine(message);
        return int.Parse(Console.ReadLine());
}

int[] ArrayUser(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadNumber($"Введите число");
    }
    return array;
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
        sum = sum + 1;
        }
    }
    return sum;
}

int lenght = ReadNumber("Введите длину массива");
int[] array;
array = ArrayUser(lenght);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Количество чисел больше 0 - {Sum(array)}");