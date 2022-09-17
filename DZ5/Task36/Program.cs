// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = new int[new Random().Next(1, 10)];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях = {SumOddNumbers(array)}");

int SumOddNumbers (int[] array) 
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++) 
    if (i % 2 != 0)
    {
        sum += array[i];
    }
    return sum;
}

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-100, 100);
        index++;
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"{array[index]}, ");
        index++;
    }
}

