Console.Clear();

int n = GetNum("Ведите кол-во строк: ");
int m = GetNum("Ведите кол-во столбцов: ");

int[,] arrayX = CreateArray(n, m);

ShowArray(arrayX);

CalculateArray(arrayX);

Console.WriteLine();
ShowArray(arrayX);

int GetNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[,] CreateArray(int n, int m)
{
    int[,] array = new int[n, m];
    for (int col = 0; col < n; col++)
    {
        for (int row = 0; row < m; row++)
        {
            array[col, row] = new Random().Next(0, 50);
        }
    }
    return array;
}

void CalculateArray(int[,] array)
{
    for (int col = 0; col < array.GetLength(0); col++)
    {
        for (int row = 0; row < array.GetLength(1); row++)
        {
            if (row % 2 != 0 && col % 2 != 0)
            {
                array[col, row] = (array[col, row] * array[col, row]);
            }
        }
    }
    // return array; понятно
}

void ShowArray(int[,] array)
{
    for (int col = 0; col < array.GetLength(0); col++)
    {
        for (int row = 0; row < array.GetLength(1); row++)
        {
            Console.Write($"{array[col, row]}\t");
        }
        Console.WriteLine();
    }
}