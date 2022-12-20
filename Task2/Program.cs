// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка


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



int[] arrayRes = MinimumSumElementsArrayRow(arrayResult, line);


//создаем МЕТОД который считает сумму каждой строки и 
//помещает эти суммы в новый массив 1 ранга
int[] MinimumSumElementsArrayRow(int[,] arrayResult, int lineArray)
{
    int arithmeticMean = 0;
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
                arraySumLine[count] = arithmeticMean;
                count++;
                arithmeticMean = 0;
            }
        }

    }

    return arraySumLine;
}

//вызываем метод печати сумм в каждой строке
PrintArray(arrayRes);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Сумма в {i} строке равна: {array[i]} ");
    }
}

int minNumInArray = SearchMinSumInLine(arrayRes);

//МЕТОД поиска минимальной суммы в строках(работаем с массивом 1 ранга.в 
//в нем каждый послед.элемент это сумма строк двумерного массива)
int SearchMinSumInLine(int[] arrayRes)
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



int resultIndex = SearchIndexMinNumInLineArray(minNumInArray, arrayRes);

//МЕТОД поиска индекса с минимальной суммой
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
