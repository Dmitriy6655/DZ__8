// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с
//  наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

//**************************////**********************///*****************

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

//проверка чего больше в массиве (строк или столбцов)

//обращаемся к методу RandomArrayInt для заполнения двумерного массива
//случайными числами типа int
int[,] arrayResult = RandomArrayInt(arrayInt);

//печатаем заполненный массив 
PrintResultArrayInt(arrayResult);

//создаем новый массив с рангом 1 и помещаем в него
// то что вернул метод MinimumSumElementsArrayRow

int[] arrayRes = MinimumSumElementsArrayRow(arrayResult, line);

//вызываем метод печати одномерного массива
PrintArray(arrayRes);

int[] MinimumSumElementsArrayRow(int[,] arrayResult, int lineArray)
{

    //string result = String.Empty;
    int arithmeticMean = 0;
    //Console.Write($"тест {result}");
    int count = 0;
    var i = 0;
    int[] arraySumLine = new int[lineArray];

    while (count < arrayResult.GetLength(0))
    {
        for (i = 0; i < arrayResult.GetLength(1); i++)

        {
            arithmeticMean = (arithmeticMean + arrayResult[count, i]);

            if (i == arrayResult.GetLength(1) - 1)
            {
                //arithmeticMean = arithmeticMean / arrayResult.GetLength(0);
                //arithmeticMean = Math.Round(arithmeticMean, 1);
                // result = result + string.Format("  {0};", arithmeticMean);
                //Console.WriteLine($"Result равно:{result}");
                //Console.WriteLine($"Count равно:{count}");
                arraySumLine[count] = arithmeticMean;
                count++;
                arithmeticMean = 0;
            }
        }

    }

    return arraySumLine;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Сумма в {i} строке равна: {array[i]} ");
    }
}


//МЕТОД поиска минимальной суммы в строках
int SearchMin(int[] arrayRes)
{
    int minSumInLine = 0;

    int i = 1;

    minSumInLine = arrayRes[0];

    for (i = 0; i < arrayRes.Length; i++)
    {

        if (arrayRes[i] < minSumInLine)
        {
            minSumInLine = arrayRes[i];

        }

    }

    return minSumInLine;
}

int minNumInArray = SearchMin(arrayRes);

int resultIndex = SearchIndexMinNumInLineArray(minNumInArray, arrayRes);

void PrintIndex(int k)
{

    Console.WriteLine($"Индекс строки с минимальной суммой равен: {k} ");

}

PrintIndex(resultIndex);

//МЕТОД поиска индекса строки с мин. суммой
int SearchIndexMinNumInLineArray(int minNumInArray, int[] arrayRes)

{
    int index = 0;
    for (int i = 0; i < arrayRes.Length; i++)
    {
        if (minNumInArray == arrayRes[i])
        {
            index = i;
        }
    }
    return index;
}
