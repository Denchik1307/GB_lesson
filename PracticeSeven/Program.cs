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
}


void ExampleFiftyFour()
{
    /* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
        В итоге получается вот такой массив:
        7 4 2 1
        9 5 3 2
        8 4 4 2 */

    int linesVol = GetPositiveInt("введите количество строк: ");
    int columnsVol = GetPositiveInt("введите количество столбцов: ");

    int[,] number = new int[linesVol, columnsVol];

    FillArrayRandomNumbers(number, 0, 10);

    Console.WriteLine("Массив до:");

    ShowArray<int>.ShowDualLayerArrayWithIndex(number);

    SortRowDualLayerArray(number, IsLowToHigh: false);

    Console.WriteLine("\nМассив с упорядоченными значениями");
    ShowArray<int>.ShowDualLayerArrayWithIndex(number);
}

void ExampleFiftySix()
{
    /* Задача 56: Задайте прямоугольный двумерный массив. 
    Напишите программу, которая будет находить 
    строку с наименьшей суммой элементов.*/

    int sizeArray = GetPositiveInt("введите размер квадратного массива: ");
    int[,] sqareArray = new int[sizeArray, sizeArray];

    FillArrayRandomNumbers(sqareArray, 0, 50);

    ShowArray<int>.ShowDualLayerArrayWithIndex(sqareArray);

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

    int sizeOne = GetPositiveInt("Введите размер №1 матриц: ");
    int sizeTwo = GetPositiveInt("Введите размер №2 матриц: ");

    int[,] matrixOne = new int[sizeOne, sizeTwo];
    int[,] matrixTwo = new int[sizeTwo, sizeOne];

    FillArrayRandomNumbers(matrixOne, 0, 3);
    FillArrayRandomNumbers(matrixTwo, 0, 3);

    long[,] matrixResult = MatrixSumm(matrixOne, matrixTwo);
    long[,] matrixResultTwo = MatrixSumm(matrixTwo, matrixOne);


    ShowArray<int>.ShowDualLayerArrayWithIndex(matrixOne, "матрица №1\n");

    Console.WriteLine();
    ShowArray<int>.ShowDualLayerArrayWithIndex(matrixTwo, "матрица №2\n");

    Console.WriteLine();
    ShowArray<long>.ShowDualLayerArrayWithIndex(matrixResult, "результат A х B\n");

    Console.WriteLine();
    ShowArray<long>.ShowDualLayerArrayWithIndex(matrixResultTwo, "результат B х A\n");
}

void ExampleSixty()
{
    /* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    Напишите программу, которая будет построчно выводить массив, 
    добавляя индексы каждого элемента.*/

    int sideOne = GetPositiveInt("Введите размерность 1: ");
    int sideTwo = GetPositiveInt("Введите размерность 2: ");
    int sideThree = GetPositiveInt("Введите размерность 3: ");

    int[,,] resultArray = Create3DMassive(sideOne, sideTwo, sideThree);

    for (int z = 0; z < resultArray.GetLength(2); z++)
    {
        for (int x = 0; x < resultArray.GetLength(0); x++)
        {
            for (int y = 0; y < resultArray.GetLength(1); y++)
            {
                Console.Write($"{resultArray[x, y, z],6} ({x},{y},{z})");
            }
            Console.WriteLine();
        }

    }
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
        if (x <= y + 1 && x + y < sizeArrayX - 1)
            y++;
        else if (x < y && x + y >= sizeArrayX - 1)
            x++;
        else if (x >= y && x + y > sizeArrayX - 1)
            y--;
        else
            x--;
        ++numberForSpiralArray;
    }

    ShowArray<int>.ShowDualLayerArrayWithIndex(spiralArray, "Спираль ");
}


uint GetNumberExercise(int first, int second, int third, int four, int five)
{
    string text = ($"Введите номер задачи {first}, {second}, {third}, {four} или {five} :");
    Console.Write(text);
    uint value;
    while (!uint.TryParse(Console.ReadLine(), out value)
            ^ value != first
            ^ value != second
            ^ value != third
            ^ value != four
            ^ value != five
            )
    {
        Console.WriteLine($"Ошибка ввода!!\n{text}");
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

long[,] MatrixSumm(int[,] arrayA, int[,] arrayB)
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

int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int maxRandom = 20;
    int minRandom = 10;
    Random rand = new Random();
    int[,,] array = new int[size1, size2, size3];
    int tmp = rand.Next(minRandom, maxRandom); ;
    List<int> listNum = new List<int>();
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


class ShowArray<T>
{
    public static void ShowDualLayerArrayWithIndex(T[,] inputArray, string text = "", bool IsIndex = false)
    {
        Console.WriteLine(text);
        for (int row = 0; row < inputArray.GetLength(0); row++)
        {
            for (int col = 0; col < inputArray.GetLength(1); col++)
            {
                Console.Write($"{inputArray[row, col],4}");
                if (IsIndex)
                {
                    Console.Write($"{row},{col}");
                }
            }
            Console.WriteLine();
        }
    }
}



