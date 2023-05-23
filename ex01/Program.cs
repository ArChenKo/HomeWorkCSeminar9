// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

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
void PrintN (int startNum, int finishNum=1) // метод вывода натуральных чисел от заданного до 1
{
    if(startNum < finishNum) return;
    else if (startNum==finishNum) Console.Write(startNum);
    else Console.Write(startNum+", ");
    startNum--;
    PrintN(startNum);
}

int number = Parametr("Введите число N: ");
Console.Write($"N = {number} -> ");
PrintN(number);