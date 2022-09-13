// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr = CreateArray();
PrintArray(arr);

Console.WriteLine();
int[] arr1 = CreateArray1();
PrintArray(arr1);


int[] CreateArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine();
}


int[] CreateArray1()
{
    Random rnd = new Random();
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);

    }
    return array;
}



