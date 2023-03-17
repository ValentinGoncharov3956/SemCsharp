// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и 
// положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29,
// сумма отрицательных равна -20.


int ReadNumber(string message)
{
        Console.WriteLine(message);
        return int.Parse(Console.ReadLine());
}

int[] RandomArray(int length, int leftRange, int rigthRange)
{
    // int length = 12;
    // int leftRange = -9;
    // int rigthRange = 9;

    int[] array = new int[length];

    for(int i=0; i < array.Length; i++)
        {
            array[i] = Random.Shared.Next(leftRange, rigthRange + 1);
        }
    return array;
}

(int, int) SumPosandNegElem(int[] array)
{
    int SumPos = 0;
    int SumNeg = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            SumPos += array[i]; // SumPos = SumPos + array[i];
        }
        else
        {
            SumNeg += array[i];
        }
    }
    return (SumPos, SumNeg);
}

int lengthArray = ReadNumber("Задайте длину массива");
int leftBorder = ReadNumber("Задайте левую гранциу");
int rightBorder = ReadNumber("Задайте правую границу");

int[] ourArray = RandomArray(lengthArray, leftBorder, rightBorder);

Console.WriteLine($"[{string.Join(", ", ourArray)}]");
(int sumP, int sumN) = SumPosandNegElem(ourArray);
Console.WriteLine($"Сумма положительных элементов = {sumP}");
Console.WriteLine($"Сумма отрицательных элементов = {sumN}");







// int[] array = new int[num];
// FillRandomArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");

    // int length = array.length(12);
    // array[] = Random.Shared.Next(-9,10) 


// void FillRandomArray(int[] array)
// {
//         for(int i=0; i < num; i++)
//         {
//                 array[i] = Random.Shared.Next(-9,10);
//         }
// }

// string a = "abcd";
// Console.WriteLine($"[{string.Join(", ", a.ToArray())}]");
