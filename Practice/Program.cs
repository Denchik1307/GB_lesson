Console.Clear();

Select_exisize();

void Select_exisize()
{
    try
    {
        Print("Введите номер задачи (10, 13 или 15): ");
        int number_exisize = int.Parse(Console.ReadLine()!);

        switch (number_exisize)
        {
            case 10:
                HomeworkTen();
                break;
            case 13:
                HomeworkThirteen();
                break;
            case 15:
                HomeworkFourteen();
                break;
            default:
                Error();
                Select_exisize();
                break;
        }
    }
    catch
    {
        Error();
        Select_exisize();
    }
}

void HomeworkTen()
{
    try
    {
        Print("Введите трёхзначное число: ");
        string number = Console.ReadLine()!;
        number = CheckMinus(number);

        if (number.Length != 3)
        {
            Error();
            HomeworkTen();
        }
        else
        {
            Println($"{number[1]}");
        }
    }
    catch
    {
        Error();
        HomeworkTen();
    }
}

void HomeworkThirteen()
{
    try
    {
        Print("Введите число: ");
        string someNumber = Console.ReadLine()!;
        someNumber = CheckMinus(someNumber);

        if (someNumber.Length < 3)
        {
            Println("Здесь нет третьей цифры!");
        }
        else
        {
            Println(someNumber[2].ToString());
        }
    }
    catch
    {
        Error();
        HomeworkThirteen();
    }
}

void HomeworkFourteen()
{
    int startWeak = 1;
    int endWeak = 7;

    try
    {
        Print("Введите порядковый номер дня недели: ");
        int numberDayWeak = int.Parse(Console.ReadLine()!);
        if (numberDayWeak >= startWeak && numberDayWeak <= endWeak)
        {
            if (numberDayWeak == 6 ^ numberDayWeak == 7)
            {
                Println("Выходной!!!");
            }
            else
            {
                Println("Будний :'(");
            }
        }
        else
        {
            Error();
            HomeworkFourteen();
        }
    }
    catch
    {
        Error();
        HomeworkFourteen();
    }
}


void Error()
{
   // Console.Clear();
    Println("Что-то не так, попробуй ещё");
}

void Print(string msg)
{
    Console.Write(msg);
}

void Println(string msg)
{
    Console.WriteLine(msg);
}

string CheckMinus(string value)
{
    if (value[0] == '-')
    {
        value = value.Trim('-');
    }
    return value;
}
