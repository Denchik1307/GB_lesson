int firstNumber = int.Parse(Console.ReadLine()!);
int secondNumber = int.Parse(Console.ReadLine()!);

MySecretFunction(firstNumber, secondNumber);



void MySecretFunction(int a, int b)
{
    string tmp = string.Empty;
    int tmpInt;
    for (int i = 0; i < b.ToString().Length - 2; i++)
    {
        tmpInt = b % 10;
        tmp += tmpInt.ToString();
        Console.WriteLine(tmp.Contains(tmpInt.ToString())? "true": "false");
        if (!tmp.Contains(tmpInt.ToString()))
        {
            for (int j = 0; j > a.ToString().Length - 2; j--)
            {
                if (i == j)
                {
                    Console.Write($"{j} ");
                }
            }
        }
        tmpInt /= 10;
    }
}
