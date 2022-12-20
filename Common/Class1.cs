namespace Common;
public static class Helper
{

    public static void PrintResultArrayInt(int[,] arrayInt)
    {
        for (var i = 0; i < arrayInt.GetLength(0); i++)
        {
            for (var j = 0; j < arrayInt.GetLength(1); j++)
            {
                Console.Write("\t {0}", String.Join(" ", arrayInt[i, j]));
                //Console.Write($"{array[i,j]}  ");

            }
            Console.WriteLine();
        }

    }
    public static int[,] RandomArrayInt(int[,] arrayInt)
    {

        Random random = new Random();

        for (var i = 0; i < arrayInt.GetLength(0); i++)
        {
            for (var j = 0; j < arrayInt.GetLength(1); j++)
            {
                arrayInt[i, j] = random.Next(0, 20); ;
            }
        }
        return arrayInt;
    }

    public static int[,] SortingRows2DArray(int[,] arrayResult, int m, int n)
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


    public static int[,] RandomArrayIntMatrix(int[,] arrayInt)
    {
        Random random = new Random();

        for (var i = 0; i < arrayInt.GetLength(0); i++)
        {
            for (var j = 0; j < arrayInt.GetLength(1); j++)
            {
                arrayInt[i, j] = random.Next(1, 5); ;
            }
        }

        return arrayInt;
    }

    //печать 3D массива
    public static void PrintResult3DArrayInt(int[,,] arrayInt)
    {
        for (var i = 0; i < arrayInt.GetLength(0); i++)
        {
            for (var j = 0; j < arrayInt.GetLength(1); j++)
            {
                for (var k = 0; k < arrayInt.GetLength(2); k++)
                {
                    Console.Write("\t {0} ({1}, {2}, {3})", String.Join(" ", arrayInt[j, k, i]),j, k, i );
                    //Console.Write($"{array[i,j]}  ");
                }

                Console.WriteLine();

            }
             
        }

    }


//МЕТОД создания массива с неповторяющимися двузначными числами
public static int[] ArrayMix()
{
    int[] arrayLocal = new int[8];
    Random random = new Random();

    for (int i = 0; i < arrayLocal.Length; i++)
    {
        arrayLocal[i] = random.Next(10 + i * 3, 13 + i * 3);
        arrayLocal[random.Next(0, 8)] = random.Next(50 + (i * 3), 53 + (i * 3));

    }
    return arrayLocal;

}


//МЕТОД заполнения 3D массива неповторяющимися числами из метода ArrayMix()
public static int[,,] SearchRepetitionsArray(int[] array)
{

    int[,,] arrayLocal3D = new int[2, 2, 2];

    int count = 0;
   

    for (int i = 0; i < arrayLocal3D.GetLength(0); i++)
    {
        for (int j = 0; j < arrayLocal3D.GetLength(1); j++)
        {
            for (int k = 0; k < arrayLocal3D.GetLength(2); k++)
            {

                arrayLocal3D[i, j, k] = array[count];
                count++;

            }


        }

    }

    return arrayLocal3D;
}

//создаем МЕТОД заполнения массива по спирали
public static int[,] Filling2DArraySpiral (int m)
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


}


