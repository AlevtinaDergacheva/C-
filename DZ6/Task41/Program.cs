// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите число М - ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
Console.WriteLine("Введите М чисел (элементы массива) - ");
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("Количество чисел больше 0 = ");
Console.WriteLine(FindNumber(array));

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = Convert.ToInt32(Console.ReadLine());
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
int FindNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}