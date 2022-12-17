
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












// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

//создаем новую строку и помещаем в нее то что вернул метод ArithmeticMeanColumn
//int[,] resultArithmeticMeanColumn = ArithmeticMeanColumn(arrayResult, line, column);



int[,] array = ArithmeticMeanColumn(arrayResult, line, column);

//печатаем отсортированный массив 
PrintResultArrayInt(array);


int[,] ArithmeticMeanColumn(int[,] arrayResult, int m, int n)
{
    int[,] arrayLocal = new int[m, n];


    //Console.Write($"тест {result}");
    int count = 0;
    var i = 0;
    int maxPosition = 0;


    while (count < arrayResult.GetLength(0))
    {
    for (i = 0; i < arrayResult.GetLength(1) - 1; i++)

    {
        maxPosition = i;
        //Console.WriteLine($"maxPositionINdex равно:{maxPosition}");
        //Console.WriteLine($"Count равно:{count}");

        for (int j = i + 1; j < arrayResult.GetLength(1); j++)
        {
            if (arrayResult[count, j] > arrayResult[count, maxPosition])
            {
                maxPosition = j;
                //Console.WriteLine($"j равно:{j}");
            }
            int temporary = arrayResult[count, i];
            arrayResult[count, i] = arrayResult[count, maxPosition];
            arrayResult[count, maxPosition] = temporary;

            //  if (i == arrayResult.GetLength(1) - 2)
            // {
            //     count++;
            //     Console.WriteLine($"Count равно:{count}");
            // }
            }

             if (i == arrayResult.GetLength(1)-2 )
            {
                count++;
                Console.WriteLine($"Count равно:{count}");
                Console.WriteLine($"maxPosition равно:{maxPosition}");
            }
        }

    }

    return arrayResult;
}

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


