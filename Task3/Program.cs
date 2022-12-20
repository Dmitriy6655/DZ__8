// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// А*B =   a11*b11 + a12*b21    a11*b12 + a12*b22
//         a21*b21 + a22*b21    a21*b12 + a22*b22

// A =     a11 a12
//         a21 a22

using static Common.Helper;

Console.Write("Enter the size Matrix1 and Matrix2 (m*m): ");
int size = int.Parse(Console.ReadLine());

int[,] array = new int[size, size];
int[,] array2 = new int[size, size];

int[,] arrayMatrix = RandomArrayIntMatrix(array);
int[,] arrayMatrix2 = RandomArrayIntMatrix(array2);

PrintResultArrayInt(arrayMatrix);
Console.WriteLine();
PrintResultArrayInt(arrayMatrix2);
Console.WriteLine();

int[,] arrayResProductMatrix = MatrixProduct(arrayMatrix, arrayMatrix2);


// печатаем результирующую матрицу
Console.WriteLine("Результат умножения матриц равен:");
PrintResultArrayInt(arrayResProductMatrix);

//создаем МЕТОД умножения матриц
int[,] MatrixProduct(int[,] arrayMatrix, int[,] arrayMatrix2)
{
    int[,] arrayResult = new int[arrayMatrix.GetLength(0), arrayMatrix.GetLength(1)];

    for (int i = 0; i < arrayResult.GetLength(0); i++)
    {
        for (int j = 0; j < arrayResult.GetLength(1); j++)
        {

            for (int k = 0; k < arrayResult.GetLength(0); k++)
            {
                arrayResult[i, j] += arrayMatrix[i, k] * arrayMatrix2[k, j];
            }

        }
    }
    return arrayResult;
}

