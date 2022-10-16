// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


Console.WriteLine ("Введите M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (SumRec(M, N));

int SumRec(int M, int N)
{
    if (M == N) 
    {
        return M;
    }
    else
    {
      return (M + SumRec (M+1, N));  
    }
    
}