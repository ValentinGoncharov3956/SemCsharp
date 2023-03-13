// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Введите число");
string userAnswer = Console.ReadLine();
int userNumber = Convert.ToInt32(userAnswer);

Console.WriteLine(userNumber * userNumber);


//Фунцкии и массивы

// int n = array.Length;
// int find = 262;

// int index = 0;

// while (index < n)
// {

//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;  //завершает цикл, как только выполнит условие(находит то что нужно)
//     }
//     index++;
// }


// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }

// // int a1 = 11;
// // int b1 = 45;
// // int c1 = 12;
// // int a2 = 22;
// // int b2 = 56;
// // int c2 = 12;
// // int a3 = 24;
// // int b3 = 34;
// // int c3 = 16;

// //              0   1   2   3   4   5     6    7     8
// int[] array = { 11, 14, 51, 61, 62, 123, 23, 621, 32};
// // array[0] = 12;
// // Console.WriteLine(array[0]);

// int result = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );
// Console.WriteLine(result);

// // // int max1 = Max(a1, b1, c1);
// // // int max2 = Max(a2, b2, c2);
// // // int max3 = Max(a3, b3, c3);
// // // int max = Max(max1, max2, max3);

// // int max = Max(
// //     Max(a1, b1, c1), 
// //     Max(a2, b2, c2), 
// //     Max(a3, b3, c3));

// // // if(b1 > max) max = b1;
// // // if(c1 > max) max = c1;

// // // if(a2 > max) max = a2;
// // // if(b2 > max) max = b2;
// // // if(c2 > max) max = c2;

// // // if(a3 > max) max = a3;
// // // if(b3 > max) max = b3;
// // // if(c3 > max) max = c3;

// // Console.WriteLine(max);

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next (1, 10);
//         index++;
//     }
// }

// void PrintArray(int[] col)
//     {
//     int count = col.Length;
//     int position = 0;
//     while(position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }

//     }

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;
//     while (index < count)
//     {
//         if(collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }

// int[] array = new int [10];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// int pos = IndexOf(array, 4);
// Console.WriteLine(pos);