using System;

public class MainClass2
{
    public static void Main2()
    {
        Console.Clear();
        int firstNumber = int.Parse(Console.ReadLine()!);
        // Console.WriteLine($"1 {firstNumber} ");
        int secondNumber = int.Parse(Console.ReadLine()!);
        // Console.WriteLine($"2 {secondNumber} ");
        string tmp = "";
        int check;
        int print;
        // Ваш код
        for (int i = secondNumber.ToString().Length - 2; i >= 0; i--)
        {
            check = secondNumber % 10;
            // Console.WriteLine($"3 {check} ");
            tmp += check.ToString();
            // Console.WriteLine($"4 {tmp} ");
            // Console.WriteLine($"4 {check.ToString()} ");
            Console.WriteLine($"4-1 {((tmp.Contains(check.ToString())) ? "true" : "false")} ");
            bool hhh = tmp.Contains(check.ToString());
            if (hhh)
            {

            }
            else
            {
                for (int j = firstNumber.ToString().Length - 2; j >= 0; j--)
                {
                    print = firstNumber % 10;
                    // Console.WriteLine($"5 {print} ");
                    if (check == print)
                    {
                        Console.WriteLine($"6 {print} ");
                    }
                    firstNumber = firstNumber / 10;
                    // Console.WriteLine($"7 {firstNumber} ");
                }
            }
            secondNumber = secondNumber / 10;
            // Console.WriteLine($"8 {secondNumber} ");
        }
    }
}