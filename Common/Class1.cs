namespace Common;
public static class Helper
{

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
}
