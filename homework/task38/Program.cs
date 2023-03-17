// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.

// [3 7 22 2 78] -> 76

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

(int, int) MinAndMaxElem(int[] array)
{
    int SumMax = array[0];
    int SumMin = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(SumMax > array[i])
        {
            if (SumMin < array[i])
            i++;
            else
            {
                SumMin = array[i];
            }
        }
        else SumMax = array[i];
    }
    return (SumMax, SumMin);
}

int lengthArray = ReadNumber("Задайте длину массива");
int leftBorder = ReadNumber("Задайте левую границу");
int rightBorder = ReadNumber("Задайте правую границу");
int[] ourArray = RandomArray(lengthArray, leftBorder, rightBorder);
Console.WriteLine($"[{string.Join(", ", ourArray)}]");

(int Max, int Min) = MinAndMaxElem(ourArray);
Console.WriteLine($"Максимальный элемент = {Max}");
Console.WriteLine($"Минимальный элемент = {Min}");

Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {Max-Min}");

