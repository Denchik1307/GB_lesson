﻿bool debug = false;

if (!debug)
    Console.Clear();

ExisizeNumber();

void ExisizeNumber()
{
    try
    {
        switch (GetInputInt("Введите номер задачи 25, 27 или 29: "))
        {
            case 25:
                ExempleTwentyFive();
                break;
            case 27:
                ExempleTwentySeven();
                break;
            case 29:
                ExempleTwentyNine();
                break;
            default:
                ExisizeNumber();
                break;
        }
    }
    catch
    {
        Error();
        ExisizeNumber();
    }
}

void ExempleTwentyFive()
{
    try
    {
        double number = GetInputDouble("Введите число: ");
        int pow = GetInputInt("Введите степень для возведения числа: ");

        double result = MyPow(number, pow, 3);

        Println($"{number} в степени {pow} = {result}");
    }
    catch
    {
        Error();
        ExempleTwentyFive();
    }
}

void ExempleTwentySeven()
{
    try
    {
        long someNumber = GetInputLong("Введите положительное чило: ");
        int result = SummDigitNumber(someNumber);
        Println($"Сумма чисел числа {someNumber} = {result.ToString()}");
    }
    catch
    {
        Error();
        ExempleTwentySeven();
    }
}

void ExempleTwentyNine()
{
    try
    {
        int arrayLength = GetInputInt("\nВведите длинну массива: ");
        int minValue = GetInputInt("\nВведите минимальное значение числа в массиве: ");
        int maxValue = GetInputInt("\nВведите максимальное значение числа в массиве: ");
        Println(ArrayToString(RandomArray(arrayLength, minValue, maxValue)));
    }
    catch
    {
        Error();
        ExempleTwentyNine();
    }
}

int SummDigitNumber(long number)
{
    long summ = 0;
    while (number > 0)
    {
        summ += number % 10;
        number /= 10;
    }
    return ((int)summ);
}

int[] RandomArray(int lengthArray, int min, int max)
{
    int[] array = new int[lengthArray];
    for (int i = 0; i < lengthArray; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

string ArrayToString(int[] array)
{
    int count = array.Length;
    string msg = "[";
    foreach (int i in array)
    {
        msg += i;
        if (count == 1)
        {
            msg += "]";
        }
        else
        {
            msg += ",";
        }
        count--;
    }
    return msg;
}

void Println(string msg)
{
    Console.WriteLine(msg);
}

int GetInputInt(string msg = "Введите int число:")
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

long GetInputLong(string msg = "Введите long число:")
{
    Console.Write(msg);
    return long.Parse(Console.ReadLine()!);
}

double GetInputDouble(string msg = "Введите double число:")
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine()!);
}

double MyPow(double number, int pow, int range = 2)
{
    double result = 1.0d;
    for (int i = 1; i <= pow; i++)
    {
        result = result * number;
    }

    return Math.Round(result, range);
}

void Error()
{
    if (!debug)
        Console.Clear();
    Println("Что-то не так, попробуй ещё");
}