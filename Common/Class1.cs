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
                    Console.Write("\t {0} ({1}, {2}, {3})", String.Join(" ", arrayInt[j, k, i]), j, k, i);
                    //Console.Write($"{array[i,j]}  ");
                }

                Console.WriteLine();

            }

        }

    }





}


