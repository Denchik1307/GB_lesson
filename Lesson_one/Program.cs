Console.Clear();
Exisize();

void Exisize()
{

    Console.Write("\nВведите номер задачи \"2, 4, 6 или 8\": ");
    string? number_exisize = Console.ReadLine();
    switch (number_exisize)
    {
        case "2":
            Exemple_two();
            break;
        case "4":
            Exemple_four();
            break;
        case "6":
            Exemple_six();
            break;
        case "8":
            Exemple_eigth();
            break;
        default:
            Error();
            Exisize();
            break;
    }
}


void Exemple_two()
{
    try
    {
        Console.Write("\tЗадача №2 \n\tкоторое число больше из двух \n\nВведите первое число: ");
        int number_one = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nВведите второе число: ");
        int number_two = Convert.ToInt32(Console.ReadLine());
        int max_num = (number_one >= number_two ? number_one : number_two);
        Console.WriteLine("большее число -> " + max_num);
    }
    catch
    {
        Error();
        Exemple_two();
    }
}

void Exemple_four()
{
    try
    {
        int[] numbers = new int[3];
        
        Console.Write("\tЗадача №4 \n\tкоторое число больше из трех \n\nВведите первое число: ");
        numbers[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nВведите второе число: ");
        numbers[1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nВведите третье число: ");
        numbers[2] = Convert.ToInt32(Console.ReadLine());
        int max_number = numbers[0];

        for (int i = 0; i < 3; i++)
        {
            if (max_number < numbers[i]) max_number = numbers[i];
        }

        Console.WriteLine("большее число -> " + max_number);
    }
    catch
    {
        Error();
        Exemple_four();
    }
}

void Exemple_six()
{
    try
    {
        Console.Write("\n\tЗадача №6 \n\tчётное \\ нечетное \n\nВведите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        string isOdd = (number % 2 == 0 ? " <- Четное" : " <- Нечетное");

        Console.WriteLine(number + isOdd);
    }
    catch
    {
        Error();
        Exemple_six();
    }
}

void Exemple_eigth()
{
    try
    {
        Console.Write("\n\tЗадача №8 все чётные числа \n\tдо введенного числа \n\nВведите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                string style = (i % 20 == 0 ? "\n" : "\t");
                Console.Write(i + style);
            }
        }
    }
    catch
    {
        Error();
        Exemple_eigth();
    }
}

void Error()
{
    Console.Clear();
    Console.WriteLine("Чет не то, внимательней!");
}
