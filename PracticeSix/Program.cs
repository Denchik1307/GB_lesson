
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
    int linesVol = GetPositiveIntNumberFromConsole("введите количество строк: ");
    int columnsVol = GetPositiveIntNumberFromConsole("введите количество столбцов: ");
    double[,] numbers = new double[linesVol, columnsVol];
    FillArrayRandomDoubleNumbers(numbers, range: 2);
    ShowDoubleArray(numbers);
}

void ExampleFifty()
{
    int rowArray = GetPositiveIntNumberFromConsole("введите количество строк: ");
    int columnArray = GetPositiveIntNumberFromConsole("введите количество столбцов: ");
    int rowIndex = GetPositiveIntNumberFromConsole("введите номер строки: ");
    int colIndex = GetPositiveIntNumberFromConsole("введите номер столбца: ");

    int[,] numbers = new int[rowArray, columnArray];

    FillArrayRandomIntNumbers(numbers);

    ShowCellInArray(numbers, rowIndex, colIndex);
}

void ExampleFiftyTwo()
{
    int rowArray = GetPositiveIntNumberFromConsole("введите количество строк: ");
    int columnArray = GetPositiveIntNumberFromConsole("введите количество столбцов: ");

    int[,] numbers = new int[rowArray, columnArray];

    FillArrayRandomIntNumbers(numbers, 0, 10);

    ShowIntArray(numbers);

    Println("Среднее по столбцам");

    ShowMidleSummRowInArray(numbers);
}

void ShowMidleSummRowInArray(int[,] array)
{
    string results = String.Empty;
    int row;
    int col;
    for (col = 0; col < array.GetLength(1); col++)
    {
        double tmp = 0;
        for (row = 0; row < array.GetLength(0); row++)
        {
            tmp += array[row, col];
        }
        tmp /= (double)row;
        results += Math.Round(tmp, 2).ToString() + "\t";
    }
    Print(results);
}

void ShowCellInArray(int[,] array, int rowIndex, int colIndex)
{
    ShowIntArray(array);
    Println();
    if (rowIndex < array.GetLength(0) && colIndex < array.GetLength(1))
    {
        Print($"содержимое вашей ячейки[{rowIndex},{colIndex}]: {array[rowIndex, colIndex]}");
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

int GetPositiveIntNumberFromConsole(string message)
{
    Console.Write(message);
    int value;
    while(!int.TryParse(Console.ReadLine(), out value) && value > 0)
    {
        Console.Write("Только положительное число: ");
    }
    return value;
}

void FillArrayRandomDoubleNumbers(double[,] array, int min = -100, int max = 100, int range = 4)
{
    int tmpRange = 1;
    for (int i = 0; i < range; i++)
    {
        tmpRange = tmpRange * 10;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(min * tmpRange, max * tmpRange)) / tmpRange;
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

void ShowDoubleArray(double[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        Console.Write("[");
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col]},\t");
        }
        Console.WriteLine("]");
    }
}

void ShowIntArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col]}\t");
        }
        Console.WriteLine();
    }
}

