﻿
Console.Clear();

ExerciseNumber();

void ExerciseNumber()
{
    switch (GetNumberExercise(47, 50, 52))
    {
        case 47:
            ExampleThirtySeven();
            break;
        case 50:
            ExampleFifty();
            break;
        case 52:
            ExampleFiftyTwo();
            break;
        default:
            Print("Непредвиденная ошибка ввода");
            break;
    }
}

void ExampleThirtySeven()
{
    int linesVol = GetIntNumberFromConsole("введите количество строк: ");
    int columnsVol = GetIntNumberFromConsole("введите количество столбцов: ");
    double[,] numbers = new double[linesVol, columnsVol];
    FillArrayRandomDoubleNumbers(numbers);
    ShowArray(numbers);
}

void ExampleFifty()
{
    int columnArray = GetIntNumberFromConsole("введите количество строк: ");
    int rowArray = GetIntNumberFromConsole("введите количество столбцов: ");
    int colIndex = GetIntNumberFromConsole("введите номер строки: ");
    int rowIndex = GetIntNumberFromConsole("введите номер столбца: ");

    int[,] numbers = new int[columnArray, rowArray];

    FillArrayRandomIntNumbers(numbers);

    ShowCellInArray(numbers, colIndex, rowIndex);
}

void ExampleFiftyTwo()
{
    int columnArray = GetIntNumberFromConsole("введите количество строк: ");
    int rowArray = GetIntNumberFromConsole("введите количество столбцов: ");

    int[,] numbers = new int[columnArray, rowArray];

    FillArrayRandomIntNumbers(numbers, 0 , 100);
    ShowIntArray(numbers);
    Println("Среднее по столбцам");

    ShowMidleSummRowInArray(numbers);
}

void ShowMidleSummRowInArray(int[,] array)
{
    string results = String.Empty;
    int row;
    int col;
    double tmp = 0;
    for (col = 0; col < array.GetLength(0); col++)
    {
        for (row = 0; row < array.GetLength(1); row++)
        {
            tmp += array[col, row];
        }
        tmp /= (double)row;

        results += Math.Round(tmp, 2).ToString() + "\t";
    }
    Print(results);
}

void ShowCellInArray(int[,] array, int colIndex, int rowIndex)
{
    ShowIntArray(array);
    Println();
    if (colIndex < array.GetLength(0) && rowIndex < array.GetLength(1))
    {
        Print($"содержимое вашей ячейки[{colIndex},{rowIndex}]: {array[colIndex, rowIndex]}");
    }
    else
    {
        Print("нет такого индекса");
    }
    Println();
}

uint GetNumberExercise(int first, int second, int third)
{
    Console.Write("Введите номер задачи {0}, {1} или {2} :", first, second, third);
    uint value;
    while (!uint.TryParse(Console.ReadLine(), out value))
    {
        Console.WriteLine("Ошибка ввода!!");
    }
    return value;
}

int GetIntNumberFromConsole(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArrayRandomDoubleNumbers(double[,] array, int min = -100, int max = 100)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(min * 100, max * 100)) / 100;
        }
    }
}

void FillArrayRandomIntNumbers(int[,] array, int min = -100, int max = 100)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
}

void Print(string msg = "")
{
    Console.Write(msg);
}

void Println(string msg = "")
{
    Console.WriteLine(msg);
}

void ShowArray(double[,] array)
{
    for (int col = 0; col < array.GetLength(0); col++)
    {
        for (int row = 0; row < array.GetLength(1); row++)
        {
            Console.Write($"{array[col, row]}\t");
        }
        Console.WriteLine();
    }
}

void ShowIntArray(int[,] array)
{
    for (int col = 0; col < array.GetLength(0); col++)
    {
        for (int row = 0; row < array.GetLength(1); row++)
        {
            Console.Write($"{array[col, row]}\t");
        }
        Console.WriteLine();
    }
}
