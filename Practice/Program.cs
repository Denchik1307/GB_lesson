Console.Clear();

Select_exisize();

void Select_exisize()
{
    Console.Write("Введите номер задачи (10, 13 или 15): ");
    int number_exisize = int.Parse(Console.ReadLine());

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
            Console.Clear();
            Error();
            Select_exisize();
            break;
    }
}

void HomeworkTen()
{
    try
    {
        Console.Write("Введите трёхзначное число: ");
        string number_exisize = Console.ReadLine();
        if (number_exisize.Length != 3)
        {
            Error();
            HomeworkTen();
        }
        else
        {
            Console.WriteLine(number_exisize[1].ToString());

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
        string number_exisize = Console.ReadLine();
        if (number_exisize.Length < 3)
        {
            Console.WriteLine("Здесь нет третьей цифры!");
        }
        else
        {
            Console.WriteLine(number_exisize[2].ToString());

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
    try
    {
        Console.Write("Введите порядковый номер дня недели: ");
        string number_exisize = Console.ReadLine();
        if (number_exisize.Length != 1)
        {
            Error();
            HomeworkFourteen();
        }
        else
        {
            if (number_exisize == "6" ^ number_exisize == "7")
            {
                Console.WriteLine("Выходной!!!");
            }
            else
            {
                Console.WriteLine("Будний :'(");
            }
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
