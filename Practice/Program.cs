Console.Clear();

Select_exisize();

void Select_exisize()
{
    try
    {
        Console.Write("Введите номер задачи (10, 13 или 15): ");
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
        Console.Write("Введите трёхзначное число: ");
        string number = Console.ReadLine()!;
        if (number.Length != 3)
        {
            Error();
            HomeworkTen();
        }
        else
        {
            Console.WriteLine(number[1].ToString());
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
        Console.Write("Введите число: ");
        string someNumber = Console.ReadLine()!;
        if (someNumber.Length < 3)
        {
            Console.WriteLine("Здесь нет третьей цифры!");
        }
        else
        {
            Console.WriteLine(someNumber[2].ToString());

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
        Console.Write("Введите порядковый номер дня недели: ");
        int numberDayWeak = int.Parse(Console.ReadLine()!);
        if (numberDayWeak >= startWeak && numberDayWeak <= endWeak)
        {
            if (numberDayWeak == 6 ^ numberDayWeak == 7)
            {
                Console.WriteLine("Выходной!!!");
            }
            else
            {
                Console.WriteLine("Будний :'(");
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
        HomeworkTen();
    }
}


void Error()
{
    Console.Clear();
    Console.WriteLine("Что-то не так, попробуй ещё");
}
