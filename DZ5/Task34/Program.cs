// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = new int[new Random().Next(1, 10)];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных элементов массива = {EvenNumbers(array)}");

int EvenNumbers (int[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    if (array[i] % 2 == 0)
    {
        count += 1;
    }
    return count;
}

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(100, 1000);
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

