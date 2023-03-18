// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.


int lenght = 7;                                         // присваеваем длину массива, через ReadNumber, можно запросить у пользователя любую длинну.
void RandomArray(int[] array)
{
        for(int i=0; i < lenght; i++)
        {
                array[i] = Random.Shared.Next(1,100);           // присваеваем диапазон случайных чисел
        }
}

int[] array = new int[lenght];
RandomArray(array);

int[] array2 = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    array2[i] = array[i];
}
array2[0] = 124;
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine(string.Join(", ", array2));