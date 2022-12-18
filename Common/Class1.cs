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

    // public static int[] PrintArray(int[] array)
    // {
    //     for (int i = 0; i < array.Length; i++)
    //     {
    //         Console.WriteLine(array[i]);
    //     }
    // }

}
