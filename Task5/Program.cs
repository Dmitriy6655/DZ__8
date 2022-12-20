// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


using static Common.Helper;

Console.WriteLine("Input size array:");
int m = int.Parse(Console.ReadLine());


int[,] matrixRes = Filling2DArraySpiral(m);

//создаем МЕТОД заполнения массива по спирали
int[,] Filling2DArraySpiral (int m)
{

int[,] matrix = new int[m, m];

int f = 1;
int d = 0;
int j = 0;

while (f <= m * m)
{
    matrix[d, j] = f;
    if (d <= j + 1 && d + j < m - 1)
        ++j;
    else if (d < j && d + j >= m - 1)
        ++d;
    else if (d >= j && d + j > m - 1)
        --j;
    else
        --d;
    ++f;
}
return matrix;
}


PrintResultArrayInt(matrixRes);
