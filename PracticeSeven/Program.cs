Console.Clear();

ExerciseNumber();

void ExerciseNumber()
{
    switch (GetNumberExercise(54, 56, 58, 60, 62))
    {
        case 54:
            ExampleFiftyFour();
            break;
        case 56:
            ExampleFiftySix();
            break;
        case 58:
            ExampleFiftyEigth();
            break;
        case 60:
            ExampleSixty();
            break;
        case 62:
            ExampleSixtyTwo();
            break;
        default:
            Console.WriteLine("Непредвиденная ошибка ввода");
            break;
    }

    EndProgramm();
}

void ExampleFiftyFour()
{
    /* Задача 54: Задайте двумерный массив. Напишите программу, 
    которая упорядочит по убыванию 
    элементы каждой строки двумерного массива.*/
    const int MIN_RANDOM = 0;
    const int MAX_RANDOM = 50;

    int linesVol = GetPositiveInt("введите количество строк: ");
    int columnsVol = GetPositiveInt("введите количество столбцов: ");

    int[,] number = new int[linesVol, columnsVol];

    FillArrayRandomNumbers(number, MIN_RANDOM, MAX_RANDOM);

    Console.WriteLine("Массив до:");

    OutputManager<int>.ShowDualLayerArrayWithIndex(number);

    SortRowDualLayerArray(number, IsLowToHigh: false);

    Console.WriteLine("\nМассив с упорядоченными значениями");
    OutputManager<int>.ShowDualLayerArrayWithIndex(number);
}

void ExampleFiftySix()
{
    /* Задача 56: Задайте прямоугольный двумерный массив. 
    Напишите программу, которая будет находить 
    строку с наименьшей суммой элементов.*/
    const int MIN_RANDOM = 0;
    const int MAX_RANDOM = 50;

    int sizeArray = GetPositiveInt("введите размер квадратного массива: ");
    int[,] sqareArray = new int[sizeArray, sizeArray];

    FillArrayRandomNumbers(sqareArray, MIN_RANDOM, MAX_RANDOM);

    OutputManager<int>.ShowDualLayerArrayWithIndex(sqareArray);

    int minSum = int.MaxValue;
    int rowIndex = 0;
    for (int row = 0; row < sizeArray; row++)
    {
        int sum = 0;
        for (int col = 0; col < sizeArray; col++)
        {
            sum += sqareArray[row, col];
        }
        if (sum < minSum)
        {
            rowIndex = row;
            minSum = sum;
        }
    }
    Console.WriteLine($"Индекс строки с наименьшей суммой {rowIndex}\nCумма элементов {minSum}");
}

void ExampleFiftyEigth()
{
    /* Задача 58: Задайте две матрицы. 
    Напишите программу, которая будет находить 
    произведение двух матриц.*/

    const int MIN_RANDOM = 0;
    const int MAX_RANDOM = 10;

    int sizeOne = GetPositiveInt("Введите размер №1 матриц: ");
    int sizeTwo = GetPositiveInt("Введите размер №2 матриц: ");

    int[,] matrixOne = new int[sizeOne, sizeTwo];
    int[,] matrixTwo = new int[sizeTwo, sizeOne];

    FillArrayRandomNumbers(matrixOne, MIN_RANDOM, MAX_RANDOM);
    FillArrayRandomNumbers(matrixTwo, MIN_RANDOM, MAX_RANDOM);

    long[,] matrixResult = GetMatrixMultiplication(matrixOne, matrixTwo);
    long[,] matrixResultTwo = GetMatrixMultiplication(matrixTwo, matrixOne);


    OutputManager<int>.ShowDualLayerArrayWithIndex(matrixOne, "матрица №1\n");

    Console.WriteLine();
    OutputManager<int>.ShowDualLayerArrayWithIndex(matrixTwo, "матрица №2\n");

    Console.WriteLine();
    OutputManager<long>.ShowDualLayerArrayWithIndex(matrixResult, "результат A х B\n");

    Console.WriteLine();
    OutputManager<long>.ShowDualLayerArrayWithIndex(matrixResultTwo, "результат B х A\n");
}

void ExampleSixty()
{
    /* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    Напишите программу, которая будет построчно выводить массив, 
    добавляя индексы каждого элемента.*/

    int sideOne = GetPositiveInt("Введите размерность 1: ");
    int sideTwo = GetPositiveInt("Введите размерность 2: ");
    int sideThree = GetPositiveInt("Введите размерность 3: ");

    int[,,] array3D = Create3DMassive(sideOne, sideTwo, sideThree);

    OutputManager<int>.ShowThrityLayerArrayWithIndex(array3D, "3D массив ", true);
}

void ExampleSixtyTwo()
{
    // Задача 62: Заполните спирально массив 4 на 4. 

    int sizeArrayX = GetPositiveInt("Введите размер массива: ");

    int[,] spiralArray = new int[sizeArrayX, sizeArrayX];

    int numberForSpiralArray = 1;
    int x = 0;
    int y = 0;

    while (numberForSpiralArray <= sizeArrayX * sizeArrayX)
    {
        spiralArray[x, y] = numberForSpiralArray;
        if (x <= y + 1 && x + y < sizeArrayX - 1) y++;
        else if (x < y && x + y >= sizeArrayX - 1) x++;
        else if (x >= y && x + y > sizeArrayX - 1) y--;
        else x--;
        ++numberForSpiralArray;
    }

    OutputManager<int>.ShowDualLayerArrayWithIndex(spiralArray, "Спираль ");
}


uint GetNumberExercise(int first, int second, int third, int four, int five)
{
    string text = ($"Введите номер задачи {first}, {second}, {third}, {four} или {five} :");
    Console.Write(text);
    uint value;
    while (!uint.TryParse(Console.ReadLine(), out value)
            ^ value > 0
            && value != first
            && value != second
            && value != third
            && value != four
            && value != five
            )
    {
        Console.Write($"Ошибка ввода!!\n{text}");
    }
    Console.Clear();
    return value;
}

void SortRowDualLayerArray(int[,] inputArray, bool IsLowToHigh = true)
{
    int index = inputArray.GetLength(0);
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(1) - 1; k++)
            {
                if (IsLowToHigh)
                {
                    if (inputArray[i, k] > inputArray[i, k + 1])
                    {
                        int temp = inputArray[i, k];
                        inputArray[i, k] = inputArray[i, k + 1];
                        inputArray[i, k + 1] = temp;
                    }
                }
                else
                {
                    if (inputArray[i, k] < inputArray[i, k + 1])
                    {
                        int temp = inputArray[i, k];
                        inputArray[i, k] = inputArray[i, k + 1];
                        inputArray[i, k + 1] = temp;
                    }
                }
            }
        }
    }
}

// void SortRow(int[] array, bool IsLowToHigh = true)
// {
//     // TODO: 
// }

long[,] GetMatrixMultiplication(int[,] arrayA, int[,] arrayB)
{
    int size = arrayA.GetLength(0);
    long[,] result = new long[size, size];
    long tmp;

    for (int firstSize = 0; firstSize < size; firstSize++)
    {
        for (int secondSize = 0; secondSize < size; secondSize++)
        {
            tmp = 0;
            for (int i = 0; i < arrayA.GetLength(1); i++)
            {
                tmp += arrayA[firstSize, i] * arrayB[i, secondSize];
            }
            result[firstSize, secondSize] = tmp;
        }
    }

    return result;
}

int GetPositiveInt(string message)
{
    Console.Write(message);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) ^ value < 0)
    {
        Console.Write("Error\n" + message);
    }
    return value;
}

void FillArrayRandomNumbers(int[,] array, int min = -100, int max = 100)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
}

int[,,] Create3DMassive(int size1, int size2, int size3, int minRandom = 0, int maxRandom = 100)
{
    Random rand = new Random();

    int[,,] array = new int[size1, size2, size3];

    int tmp = rand.Next(minRandom, maxRandom);

    HashSet<int> listNum = new HashSet<int>();

    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size3; k++)
            {
                while (listNum.Contains(tmp))
                {
                    tmp = rand.Next(minRandom, maxRandom);
                }
                listNum.Add(tmp);
                array[i, j, k] = tmp;
            }
        }
    }

    return array;
}

void EndProgramm()
{
    Console.Write("\n" + "Press any key...");
    Console.CursorVisible = false;
    Console.ReadKey();
    Console.Clear();
    Console.CursorVisible = true;
}


class OutputManager<T>
{
    const int SPACE_FOR_PRINT = 5;

    public static void ShowDualLayerArrayWithIndex(T[,] inputArray, string text = "", bool IsWithIndex = false)
    {
        Console.WriteLine(text);
        for (int row = 0; row < inputArray.GetLength(0); row++)
        {
            for (int col = 0; col < inputArray.GetLength(1); col++)
            {
                Console.Write($"{inputArray[row, col],SPACE_FOR_PRINT}");
                if (IsWithIndex)
                {
                    Console.Write($" ({row},{col}) ");
                }
            }
            Console.WriteLine();
        }
    }

    public static void ShowThrityLayerArrayWithIndex(T[,,] inputArray, string text = "", bool IsWithIndex = false)
    {
        Console.WriteLine(text);
        for (int z = 0; z < inputArray.GetLength(2); z++)
        {
            for (int x = 0; x < inputArray.GetLength(0); x++)
            {
                for (int y = 0; y < inputArray.GetLength(1); y++)
                {
                    Console.Write($"{inputArray[x, y, z],SPACE_FOR_PRINT} ");
                    if (IsWithIndex)
                    {
                        Console.Write($" ({x},{y},{z}) ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

}
