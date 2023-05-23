// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//            Даны два неотрицательных числа m и n.

int Parametr(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    if (int.TryParse(value, out int val))
    {
        if (val >= 0)
        {
            return val;
        }
        Console.WriteLine("Подходят только положительные целые числа.");
        val = Parametr("Введите значение еще раз:");
        return val;
    }
    else
    {
        Console.WriteLine("Введено недопустимое значение.");
        val = Parametr("Введите значение еще раз:");
        return val;
    }
}
int Accerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Accerman(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Accerman(m - 1, Accerman(m, n - 1));
    }
    else
        return n + 1;
}
int ResultAccer()
{
    int m = Parametr("Введите значение m:");
    int n = Parametr("Введите значение n:");
    if (n < 5 && m < 4)
    {
        int value = Accerman(m, n);
        return value;
    }
    else if (n == 0 && m < 5)
    {
        int value = Accerman(m, n);
        return value;
    }
    else
    {
        Console.WriteLine("Переполнение стека. Слишком большие значения.\n Введите другие значения.");
        return ResultAccer();
    }
}

Console.WriteLine("Вычислим функцию Аккермана.");
Console.WriteLine($"Результат функции Аккермана: {ResultAccer()}");