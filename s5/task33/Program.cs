// Задача 33: Задайте массив. Напишите 
// программу, которая определяет, присутствует ли 
// заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


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

bool Detector(int[] array, int Numb)
{
    bool result = false;
    for(int i = 0; i < array.Length; i++)
    {
        if (Numb == array[i]) 
        {
            result = true;
            break;
        }
    }
    return result;
}

int lengthArray = ReadNumber("Задайте длину массива");
int leftBorder = ReadNumber("Задайте левую границу");
int rightBorder = ReadNumber("Задайте правую границу");
int[] ourArray = RandomArray(lengthArray, leftBorder, rightBorder);
Console.WriteLine($"[{string.Join(", ", ourArray)}]");

int Find = ReadNumber("Введите искомое число");
bool res = Detector(ourArray, Find);
Console.WriteLine($"{res}");


