Console.Clear();

ExerciseNumber();

void ExerciseNumber()
{
    switch (GetNumberExercise(34, 36, 38))
    {
        case 34:
            ExampleThirtyFour();
            break;
        case 36:
            ExampleThirtySix();
            break;
        case 38:
            ExampleThirtyEigth();
            break;
        default:
            Print("Непредвиденная ошибка ввода");
            break;
    }
}

void ExampleThirtyFour()
{
    int[] randArray = GetRandomArrayWithRange(10, 100, 999);
    int count = CountOddInArray(randArray);
    Print($"Массив {ArrayIntToStringForPrint(randArray)} содержит {count} чётных чисел.");
}

void ExampleThirtySix()
{
    int[] randArray = GetRandomArrayWithRange(4);
    Print(
        $"\nМассив {ArrayIntToStringForPrint(randArray)} сумма элементов нечетных позиций = {(SummArrayElement(randArray, "event"))}.\n"
    );
}

void ExampleThirtyEigth()
{
    double[] array = GetArrayFromConsole();
    Println(ArrayDoubleToStringForPrint(array));
    Println("Системно\t\t" + Math.Round((array.Max() - array.Min()), 2).ToString());
    Print("Собственные ф-ции\t" + Math.Round((MaxInArray(array) - MinInArray(array)), 2).ToString());
}

int SummArrayElement(int[] arr, string mask = "all")
{
    int summ = 0;
    switch (mask)
    {
        case "event":
            for (int i = 1; i < arr.Length; )
            {
                summ += arr[i];
                i += 2;
            }
            break;
        case "odd":
            for (int i = 0; i < arr.Length; )
            {
                summ += arr[i];
                i += 2;
            }
            break;
        default:
            for (int i = 0; i < arr.Length; i++)
            {
                summ += arr[i];
            }
            break;
    }
    return summ;
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

int CountOddInArray(int[] inputArray)
{
    int count = 0;
    foreach (int i in inputArray)
    {
        if (i % 2 == 0)
            count++;
    }
    return count;
}

int[] GetRandomArrayWithRange(int lengthArray, int minValue = -100, int maxValue = 100)
{
    int[] tmpArray = new int[lengthArray];
    for (int i = 0; i < lengthArray; i++)
    {
        tmpArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return tmpArray;
}

double[] GetArrayFromConsole(string msg = "Введите массив вещественных чисел разделяя пробелом: ")
{
    Console.Write(msg);
    string[] inputArray = Console.ReadLine()!.Split(" ");
    double[] doubleArray = new double[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        doubleArray[i] = double.Parse(inputArray[i]);
    }

    return doubleArray;
}

void Print(string msg)
{
    Console.Write(msg);
}

void Println(string msg)
{
    Console.WriteLine(msg);
}

string ArrayIntToStringForPrint(int[] inputArray)
{
    string[] stringArray = new string[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        stringArray[i] = inputArray[i].ToString();
    }
    string tmp = "[" + string.Join(", ", stringArray) + "]";
    return tmp;
}

string ArrayDoubleToStringForPrint(double[] inputArray)
{
    string[] stringArray = new string[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        stringArray[i] = inputArray[i].ToString();
    }
    string tmp = "[" + string.Join(", ", stringArray) + "]";
    return tmp;
}

double MaxInArray(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])
            max = arr[i];
    }
    return max;
}

double MinInArray(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
            min = arr[i];
    }
    return min;
}


