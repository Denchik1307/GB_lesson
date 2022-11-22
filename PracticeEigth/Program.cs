ConsoleColor RED = ConsoleColor.Red;
ConsoleColor YELLOW = ConsoleColor.Yellow;
ConsoleColor GREEN = ConsoleColor.Green;
ConsoleColor WHITE = ConsoleColor.White;

Console.Clear();


ExerciseNumber();

void ExerciseNumber()
{
    switch (GetNumberExercise(64, 66, 68))
    {
        case 64:
            ExampleSixtyFour();
            break;
        case 66:
            ExampleSixtySix();
            break;
        case 68:
            ExampleSixtyEigth();
            break;
        default:
            Console.WriteLine("Непредвиденная ошибка ввода");
            break;
    }
    EndProgramm();
}

uint GetNumberExercise(int first, int second, int third)
{
    string text = ($"Введите номер задачи {first}, {second} или {third} : ");
    Console.Write(text);
    uint value;
    while (!uint.TryParse(Console.ReadLine(), out value)
            ^ value > 0
            && value != first
            && value != second
            && value != third
            )
    {
        Console.Write($"Ошибка ввода!!\n{text}");
    }
    Console.Clear();
    return value;
}

void ExampleSixtyFour()
{
    ChangeColor(RED);
    Console.WriteLine("\n" +
    @"Задача 64: Задайте значение N. Напишите программу, 
    которая выведет все натуральные числа в промежутке от N до 1. 
    Выполнить с помощью рекурсии.");
    ChangeColor(YELLOW);

    const int TO_ONE = 1;
    int n = GetPositiveInt("Введите целое число N:");

    ChangeColor(GREEN);

    Console.WriteLine($"\nN = {n} => {GetNaturalNumber(n, TO_ONE)}");

    ChangeColor(WHITE);
}

void ExampleSixtySix()
{
    ChangeColor(RED);
    Console.WriteLine("\n" +
    @"Задача 66: Задайте значения M и N. Напишите программу, 
    которая найдёт сумму натуральных элементов в промежутке от M до N." + "\n");
    ChangeColor(YELLOW);

    int m = GetPositiveInt("Введите целое число M: ");
    int n = GetPositiveInt("Введите целое число N: ");

    ChangeColor(GREEN);
    if (m < n)
    {
        Console.WriteLine($"M = {m}; N = {n} => {CountSumNaturalDigit(m, n)}");
    }
    else
    {
        Console.WriteLine("N должно быть больше M ");
    }


    ChangeColor(WHITE);
}

void ExampleSixtyEigth()
{
    ChangeColor(RED);
    Console.WriteLine("\n" +
    @"\n Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29" + "\n");
    ChangeColor(YELLOW);

    int m = GetPositiveInt("Введите целое число M:");
    int n = GetPositiveInt("Введите целое N:");

    ChangeColor(GREEN);
    Console.WriteLine($"m = {m}, n = {n} => A({m},{n})={AkkermanFunction(m, n)}");

    ChangeColor(WHITE);
}

int GetPositiveInt(string message)
{
    Console.Write(message);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) ^ value <= 0)
    {
        Console.Write("Error\n" + message);
    }
    return value;
}

int AkkermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return AkkermanFunction(m - 1, 1);
    else
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

string GetNaturalNumber(int n, int m)
{
    if (n >= m)
        return $"{n},{GetNaturalNumber(n - m, m)}";
    return string.Empty;
}

int CountSumNaturalDigit(int m, int n)
{
    if (m != n)
        return n + CountSumNaturalDigit(m, --n);
    return n;
}

void ChangeColor(ConsoleColor color)
{
    Console.ForegroundColor = color;
}

void EndProgramm()
{
    Console.Write("\n" + "Press any key...");
    Console.CursorVisible = false;
    Console.ReadKey();
    Console.Clear();
    Console.CursorVisible = true;
    ChangeColor(WHITE);
}