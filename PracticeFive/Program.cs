Console.Clear();

ExerciseNumber();

void ExerciseNumber()
{
    switch (GetNumberExercise(41, 43))
    {
        case 41:
            ExampleFortyOne();
            break;
        case 43:
            ExampleFortyThree();
            break;
        default:
            Print("Непредвиденная ошибка ввода");
            break;
    }
}

void ExampleFortyOne()
{
    int[] arr = GetIntArrayFromConsole();
    Println(ArrayIntForPrint(arr));
    int positiveCount = CountPositiveInArray(arr);
    Print(positiveCount.ToString());
}

void ExampleFortyThree()
{
    double b1 = GetInputInt("введите число b1: ");
    double k1 = GetInputInt("введите число k1: ");
    double b2 = GetInputInt("введите число b2: ");
    double k2 = GetInputInt("введите число k2: ");

    double x =-(b2 - b1) / (-k1 + k2);
    double y = k2 * x + b2;

    Console.WriteLine($"две прямые пересекутся в точке с координатами X: {Math.Round(x,2)}, Y: {Math.Round(y,2)}");
}

int GetInputInt(string msg)
{
    Console.Write(msg);
    int value;
    while (!int.TryParse(Console.ReadLine(),out value))
    {
        Console.WriteLine("Ошибка ввода!!");
    }
    return value;
}

uint GetNumberExercise(int first, int second)
{
    Console.Write("Введите номер задачи {0} или {1} :", first, second);
    uint value;
    while (!uint.TryParse(Console.ReadLine(), out value))
    {
        Console.WriteLine("Ошибка ввода!!");
    }
    return value;
}

int CountPositiveInArray(int[] inputArray)
{
    int count = 0;
    foreach (int i in inputArray)
    {
        if (i > 0)
            count++;
    }
    return count;
}

int[] GetIntArrayFromConsole(string msg = "Введите массив вещественных чисел разделяя запятой: ")
{
    Console.Write(msg);
    string[] inputArray = Console.ReadLine()!.Split(",");
    int[] intArray = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        intArray[i] = (int.TryParse(inputArray[i], out int value)? value : -1);
    }

    return intArray;
}

void Print(string msg)
{
    Console.Write(msg);
}

void Println(string msg)
{
    Console.WriteLine(msg);
}

string ArrayIntForPrint(int[] inputArray)
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