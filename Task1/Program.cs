// Задача 54: Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static Common.Helper;

Console.Write("Enter the size line (m): ");
int line = int.Parse(Console.ReadLine());
Console.Write("Enter the size column (n): ");
int column = int.Parse(Console.ReadLine());

int[,] arrayInt = new int[line, column];

//обращаемся к методу RandomArrayInt для заполнения двумерного массива
//случайными числами типа int
int[,] arrayResult = RandomArrayInt(arrayInt);

//печатаем заполненный массив 
PrintResultArrayInt(arrayResult);

int[,] array = SortingRows2DArray(arrayResult, line, column);

int[,] SortingRows2DArray(int[,] arrayResult, int m, int n)
    {
        int[,] arrayLocal = new int[m, n];


        //Console.Write($"тест {result}");
        int count = 0;
        //int i = 0;

        while (count < arrayResult.GetLength(0))
        {
            for (int i = 0; i < arrayResult.GetLength(1); i++)
            {
                for (int j = 0; j < arrayResult.GetLength(1) - i - 1; j++)
                {
                    if (arrayResult[count, j] < arrayResult[count, j + 1])
                    {
                        int temp = arrayResult[count, j];
                        arrayResult[count, j] = arrayResult[count, j + 1];
                        arrayResult[count, j + 1] = temp;
                    }

                }

                if (i == arrayResult.GetLength(1) - 1)
                {
                    count++;
                }
            }

        }

        return arrayResult;
    }



//печатаем отсортированный массив 
PrintResultArrayInt(array);

void PrintResultArrayInt(int[,] arrayInt)
{
    for (var i = 0; i < arrayInt.GetLength(0); i++)
    {
        for (var j = 0; j < arrayInt.GetLength(1); j++)
        {
            //Console.Write("\t {0}", String.Join(" ", arrayInt[i, j]));
            Console.Write($"\t {arrayInt[i, j]}  ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

