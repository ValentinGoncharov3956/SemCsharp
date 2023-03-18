// Задача 39: Напишите программу, 
// которая перевернёт одномерный0 
// массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// int ReadNumber(string message)
// {
//         Console.WriteLine(message);
//         return int.Parse(Console.ReadLine());
// }

int[] RandomArray(int lenght, int leftRange, int rigthRange)
{
    // int length = 12;
    // int leftRange = -9;
    // int rigthRange = 9;

    int[] array = new int[lenght];

    for(int i=0; i < array.Length; i++)
        {
            array[i] = Random.Shared.Next(leftRange, rigthRange + 1);
        }
    return array;
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

// Math.

// const double PI = 3.141592653589793;
const int LENGTH = 5;
const int LEFTBORDER = -10;
const int RIGHTBORDER = 10;

int[] Myarray = RandomArray(LENGTH, LEFTBORDER, RIGHTBORDER);
Console.WriteLine($"[{string.Join(", ", Myarray)}]");
ReverseArray(Myarray);

Console.WriteLine($"[{string.Join(", ", Myarray)}]");


// int[] array = RandomArray{12, 10, 10};
// array.GetCounts();


