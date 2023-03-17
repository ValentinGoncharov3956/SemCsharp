// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int ReadNumber(string message)
{
        Console.WriteLine(message);
        return int.Parse(Console.ReadLine());
}
int lenght = 4;                                         // присваеваем длину массива, через ReadNumber, можно запросить у пользователя любую длинну.
void RandomArray(int[] array)
{
        for(int i=0; i < lenght; i++)
        {
                array[i] = Random.Shared.Next(1,100);           // присваеваем диапазон случайных чисел
        }
}

int SumElementsArray(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
       if (i % 2 != 0)
       sum = sum + array[i]; 
    }
    return sum;
}

int[] array = new int[lenght];
RandomArray(array);
int sum = SumElementsArray(array);
Console.WriteLine($"[{string.Join(", ", array)}] -> {sum}");
