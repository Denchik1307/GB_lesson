using System;
using System.Diagnostics;
using System.Collections;

// int height = int.Parse(Console.ReadLine()!) + 1;

// for (int i = 0; i <= height; i++)
// {
//     for (int j = 0; j < height - i; j++)
//     {
//         Console.Write(" ");
//     }
//     for (int k = 0; k <= i * 2; k++)
//     {
//         Console.Write("*");
//     }
//     Console.Write("\n");
// }
Stopwatch timer = new Stopwatch();

long[] arrayA = CreateArray(2_000_000);
FillArray(arrayA, max: 20, min: 0);
LinkedList<int> list = new LinkedList<int>();
foreach (int num in arrayA)
{
    list.AddLast(num);
}
timer.Start();
LinkedList<int> revList = LinkedListRevert(list);
timer.Stop();
Console.WriteLine(timer.Elapsed.ToString());

// ShowArray(list);
Console.WriteLine();
// ShowArray(revList);


long[] CreateArray(long sizeArray) => new long[sizeArray];

LinkedList<int> LinkedListRevert(LinkedList<int> list)
{
    LinkedList<int> reversedList = new LinkedList<int>();
    foreach (int i in list)
    {
        reversedList.AddFirst(i);
    }
    return reversedList;
}

void FillArray(long[] arrayForFill, int min = 0, int max = 10)
{
    for (int i = 0; i < arrayForFill.GetLength(0); i++)
    {
        arrayForFill[i] = new Random().Next(min, max);
    }
}

// void BinarySortInsert(int[] array, short n)
// {
//     int x;
//     int left;
//     int right;
//     int sred;
//     for (int i = 1; i < n; i++)
//         if (array[i - 1] > array[i])
//         {
//             x = array[i];
//             left = 0;
//             right = i - 1;
//             do
//             {
//                 sred = (left + right) >> 1;
//                 if (array[sred] < x) left = sred + 1;
//                 else right = sred - 1;
//             } while (left <= right);
//             for (int j = i - 1; j >= left; j--)
//                 array[j + 1] = array[j];
//             array[left] = x;
//         }
// }

// void ShowArray(LinkedList<int> arrayForShow)
// {
//     foreach (int n in arrayForShow)
//     {
//         Console.Write($"{n} ");
//     }
// }