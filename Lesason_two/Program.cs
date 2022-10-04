Console.Clear();

FirstExemple();
SecondExemple();
ThreeExemple();
FourExemple();


void FirstExemple()
{
    try
    {
        int first = int.Parse(Console.ReadLine()!);
        int second = int.Parse(Console.ReadLine()!);


        if ((second % first) == 0)
        {
            Console.WriteLine(second + " делится на " + first);
        }
        else if ((first % second) == 0)
        {
            Console.WriteLine(second + " делится на " + first);
        }
        else
        {
            Console.WriteLine("остаток " + second % first);
        }
    }
    catch
    {
        FirstExemple();
    }
}

void SecondExemple()
{
    string value = new Random().Next(100, 1000).ToString();

    string newValue = value[0].ToString() + value[2].ToString();

    Console.WriteLine(int.Parse(value));
    Console.WriteLine(int.Parse(newValue));
}

void ThreeExemple()
{
    try
    {
        int value = int.Parse(Console.ReadLine()!);

        if (value % 7 == 0 && value % 23 == 0)
        {
            Console.WriteLine("yeeees");
        }
        else
        {
            Console.WriteLine("Oh no");
        }
    }
    catch
    {
        ThreeExemple();
    }
}

void FourExemple()
{
    try
    {
        Console.Write("Введите первое число: ");
        int first = int.Parse(Console.ReadLine()!);
        Console.Write("Введите второе число: ");
        int second = int.Parse(Console.ReadLine()!);
        Console.WriteLine(CheckSquare(first, second));
    }
    catch
    {
        FourExemple();
    }

}



// 
string CheckSquare(int a, int b)
{
    if (Math.Pow(a, 2) == b ^ Math.Pow(b, 2) == a)
    {
        return "да ";
    }
    else
    {
        return "нет";
    }

}