// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int ReadNumber(string message)
// {
//         Console.WriteLine(message);
//         return int.Parse(Console.ReadLine());
// }

// int[] RandomArray(int lenght, int leftRange, int rigthRange)
// {
//     // int length = 12;
//     // int leftRange = -9;
//     // int rigthRange = 9;

//     int[] array = new int[lenght];

//     for(int i=0; i < array.Length; i++)
//         {
//             array[i] = Random.Shared.Next(leftRange, rigthRange + 1);
//         }
//     return array;
// }

// void ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length -i -1];
//         array[array.Length -i -1] = temp;
//     }
// }

// int[] Bin(int n, int[] array, int i, int sum)
// {
//     while (n > 0)
//     {
//         sum = n / 2;
//         i++;
//     }
//     int[] array = new int[i];
//     for (int j = 0; j < i; j++)
//     {
//         array[j] = n /= 2;
//     }
//     return array;
// }

// void ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length -i -1];
//         array[array.Length -i -1] = temp;
//     }
// }
// int num = ReadNumber("Введите число");

// int[] Myarray = Bin(num);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// ReverseArray(array);

// Console.WriteLine($"[{string.Join(", ", array)}]");

int n = 786;      //2147483647 - макс значение

int countOfDigit = 0;
int nCopy = n;

while(nCopy != 0)
{
    nCopy /= 2;
    countOfDigit++;
}
Console.WriteLine(countOfDigit);

int[] binaryNumber = new int[countOfDigit];

for (int i = 0; i < binaryNumber.Length; i++)
{
     binaryNumber[i] = n % 2;
     n /= 2; 
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length -i -1];
        array[array.Length -i -1] = temp;
    }
}

Console.WriteLine(string.Join("", binaryNumber));
ReverseArray(binaryNumber);
Console.WriteLine(string.Join("", binaryNumber));