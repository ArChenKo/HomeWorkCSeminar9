// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int Parametr(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    if (int.TryParse(value, out int val))
    {
        return val;
    }
    else
    {
        Console.WriteLine("Пустые строки и символы отличные от цифр вводить нельзя!");
        val = Parametr("Введите значение еще раз:");
        return val;
    }
}
int SumBetween(int n, int m) // метод обработки данных вложенным методом с рекурсией
{
    int minval=0;
    int maxval=0;
    if(n<m) 
    {
        minval=n+1;
        maxval=m-1;
    }
    else
    {
        minval=m+1;
        maxval=n-1;
    }
    int SumValues(int minval, int maxval, int sum=0) // метод вычисления суммы значений рекурсией
    {
        if(minval>maxval) return sum;
        sum+=minval;
        minval++;
        return SumValues(minval,maxval,sum);
    }
    int result = SumValues(minval,maxval);
    return result;
}

int m=Parametr("Введите число M:");
int n=Parametr("Введите число N:");
Console.WriteLine($"Сумма чисел между {m} и {n} = {SumBetween(n,m)}");