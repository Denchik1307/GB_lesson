Console.Clear();
int[] array = GetArrayFromConsole();
int lastNumber = 0;
int[] arraySummPair;

if (array.Length % 2 != 0)
{
    lastNumber = array[array.Length / 2 + 1];
    arraySummPair = new int[array.Length/2 + 1];
    arraySummPair[array.Length/2] = array[array.Length/2];
}
else
{
    arraySummPair = new int[array.Length/2];
}

for (int i = 0; i < array.Length/2; i++)
{
    arraySummPair[i] = array[i] * array[(array.Length-1-i)];
}

Console.WriteLine(ArrayIntToStringForPrint(arraySummPair));

string ArrayIntToStringForPrint(int[] inputArray)
{
    string[] stringArray = new string[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        stringArray[i] = inputArray[i].ToString();
    }
    string tmp = $"[{string.Join(", ", stringArray)}]";
    return tmp;
}

int[] GetArrayFromConsole(string msg = "Введите массив чисел разделяя пробелом: ")
{
    Console.Write(msg);
    string[] inputArray = Console.ReadLine()!.Split(" ");
    int[] intArray = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        intArray[i] = int.Parse(inputArray[i]);
    }

    return intArray;
}