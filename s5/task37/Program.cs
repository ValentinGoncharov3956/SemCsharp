// Задача 37: Найдите произведение пар 
// чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат 
// запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int ReadNumber(string message)
{
        Console.WriteLine(message);
        return int.Parse(Console.ReadLine());
}

int[] RandomArray(int length, int leftRange, int rigthRange)
{
    int[] array = new int[length];

    for(int i=0; i < array.Length; i++)
        {
            array[i] = Random.Shared.Next(leftRange, rigthRange + 1);
        }
    return array;
}

int[] LengthArray(int[] array)
{
    if(array.Length % 2 == 0)
    {
        return new int[array.Length / 2];
    }
    else
    {
        return new int[array.Length / 2 + 1];
    }
}

int[] FindSum(int[] array)
{
    int[] result = LengthArray(array);
    for(int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 !=0)
    {
        result[result.Length - 1] = array[array.Length / 2];
    }
    return result;
}

int lengthArray = ReadNumber("Задайте длину массива");
int leftBorder = ReadNumber("Задайте левую границу");
int rightBorder = ReadNumber("Задайте правую границу");

int[] ourArray = RandomArray(lengthArray, leftBorder, rightBorder);
int[] FindC = FindSum(ourArray);
Console.WriteLine($"[{string.Join(", ", ourArray)}] -> {string.Join(", ", FindC)}");

// Console.WriteLine($"[{string.Join(", ", FindC)}]");

