Console.Clear();
ExisizeNumber();

void ExisizeNumber()
{
    try
    {
        switch (GetInputInt("Введите номер задачи 19, 21 или 23: "))
        {
            case 19:
                ExisizeNineteenth();
                break;
            case 21:
                TwentyOne();
                break;
            case 23:
                TwentyThree();
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

void ExisizeNineteenth()
{
    try
    {
        Print((IsPalindrome(GetInputString("Введите палиндром на проверку: "))) ? "Да эт он" : "Нет не подходит");
    }
    catch
    {
        Error();
        ExisizeNineteenth();
    }
}

void TwentyOne()
{
    try
    {
        double[] pointX = new double[3];
        double[] pointY = new double[3];
        pointX = GetPointHowArray("первой точки");
        pointY = GetPointHowArray("второй точки");

        PrintCalcLength3DLine(pointX, pointY);
    }
    catch
    {
        Error();
        TwentyOne();
    }
}

void TwentyThree()
{
    try
    {
        int number = GetInputInt("Введите число: ");
        CubeNumbersPrint(number);
    }
    catch
    {
        Error();
        TwentyThree();
    }
}

void Error()
{
    Console.Clear();
    Println("Что-то не так, попробуй ещё");
}

string GetInputString(string msg)
{
    Console.Write(msg);
    return Console.ReadLine()!;
}

int GetInputInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

void Print(string msg)
{
    Console.Write(msg);
}

void Println(string msg)
{
    Console.WriteLine(msg);
}

bool IsPalindrome(string value)
{
    value = value.Trim('-');
    string temp = "";
    for (int i = value.Length - 1; i >= 0; i--)
    {
        temp += value[i];
    }

    return value == temp;
}

double[] GetPointHowArray(string msg)
{
    double[] point = new double[3];
    Print("Введите три координаты для " + msg.ToUpper() + " X,Y,Z -> ");
    string[] tmp = Console.ReadLine()!.Split(',');
    for (int i = 0; i < 3; i++)
    {
        point[i] = Convert.ToDouble(tmp[i]);
    }
    return point;
}

void PrintCalcLength3DLine(double[] x, double[] y)
{
    double tmp = 0;
    for (int i = 0; i < 3; i++)
    {
        tmp += Math.Pow(y[i] - x[i], 2);
    }
    Math.Sqrt(tmp);

    Println("~" + Math.Round(Math.Sqrt(tmp), 3).ToString());
}

void CubeNumbersPrint(int number)
{
    string tmp = "";
    int count = 1;
    while (count < number)
    {
        tmp += Convert.ToString(Math.Pow(count, 3)) + ", ";
        count++;
    }
    tmp += Convert.ToString(Math.Pow(count, 3)) + ". ";
    Print(tmp);
}