// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно
//  выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// Console.WriteLine("Hello, World!");

using static Common.Helper;

int[] arrayMix = ArrayMix();

//МЕТОД создает массив 1 ранга с неповторяющимися числами
int[] ArrayMix()
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


int[,,] arrayRes = SearchRepetitionsArray(arrayMix);

//МЕТОД заполняет массив 3 ранга неповторяющимися числами из массива 1 ранга
int[,,] SearchRepetitionsArray(int[] array)
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

//печатаем массив неповторяющихся чисел  
PrintResult3DArrayInt(arrayRes);



