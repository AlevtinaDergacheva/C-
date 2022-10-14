// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Введите число строк m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n ");
int n = Convert.ToInt32 (Console.ReadLine());
Double[,] array = new Double[m, n];


CreateArray(array);
PrintArray(array);
Random rnd = new Random();
void CreateArray(Double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;

        }
    }
}

void PrintArray(Double [,] array)
{
   for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           Console.Write ($"{array[i,j]}  ");

        }
        Console.WriteLine (" ");
    } 
}

