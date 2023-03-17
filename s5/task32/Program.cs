// Задача 32: Напишите программу замена 
// элементов массива: положительные 
// элементы замените на соответствующие 
// отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


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

// int[] ReversArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// int lengthArray = ReadNumber("Задайте длину массива");
// int leftBorder = ReadNumber("Задайте левую границу");
// int rightBorder = ReadNumber("Задайте правую границу");

// int[] ourArray = RandomArray(lengthArray, leftBorder, rightBorder);
// Console.WriteLine($"[{string.Join(", ", ourArray)}]");

// int[] Revers = ReversArray(ourArray);
// Console.WriteLine($"[{string.Join(", ", Revers)}]");

void ReversArray(int[] array)   // Решение с помощью метода void (обращаемся к массиву как к ссылке)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

int lengthArray = ReadNumber("Задайте длину массива");
int leftBorder = ReadNumber("Задайте левую границу");
int rightBorder = ReadNumber("Задайте правую границу");

int[] ourArray = RandomArray(lengthArray, leftBorder, rightBorder);
Console.WriteLine($"[{string.Join(", ", ourArray)}]");
ReversArray(ourArray);

Console.WriteLine($"[{string.Join(", ", ourArray)}]");
