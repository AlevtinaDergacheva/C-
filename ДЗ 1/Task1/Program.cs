//Определение большего и меньшего из двух чисел
Console.WriteLine ("Введите первое число - ");
int firstNumber = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число - ");
int secondNumber = Convert.ToInt32 (Console.ReadLine());

if (firstNumber < secondNumber)
    {
        Console.Write ("Меньшее число: ");
        Console.WriteLine (firstNumber);
        Console.Write ("Большее число: ");
        Console.WriteLine (secondNumber);
    }
else
    {
        Console.Write ("Меньшее число: ");
        Console.WriteLine (secondNumber);
        Console.Write ("Большее число: ");
        Console.WriteLine (firstNumber);
    }