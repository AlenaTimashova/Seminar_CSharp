//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int [,] CreateRandom2DArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] array = new int [rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeRows (int[,] array, int row1, int row2)
{
    if(row1 >= 0 && row1 < array.GetLength(0) &&
        row2 >= 0 && row2 < array.GetLength(0) &&
        row1 != row2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array [row1, j];
            array[row1, j] = array[row2, j];
            array[row2,j] = temp;
        }
    }
    else Console.WriteLine("Impossible to change!");
}

// Console.Write("Input a number if the first row to hange: ");
// int r1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Input a number if the second row to hange: ");
// int r2 = Convert.ToInt32(Console.ReadLine()) - 1;

// ChangeRows(myArray, r1, r2);
// Show2dArray(myArray);

//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
void MatrixTransposition(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 1; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                int temp = array[i,j];
                array[i,j] = array [j, i];
                array [j, i] = temp;
            }
        }
    }
    else Console.WriteLine("Unable to do transposition");
}
*/
//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[] GetMinIndex (int[,]array)
{
    int [] minIndex = {0, 0};
     for (int i = 0, k = 0; i < array.GetLength(0); i++, k++)
        for (int j = 0, l = 0; j < array.GetLength(1); j++, l++)
            if (array[i,j] < array[minIndex[0], minIndex[1]])
            {
                minIndex[0] = i;
                minIndex[1] = j;
            }
    return minIndex;
}

int [,] Resize(int[,] array)
{

    int [,] newArray = new int [array.GetLength(0)-1, array.GetLength(1)-1];
    int[] minIndexes = GetMinIndex(array);
    for (int i = 0, k = 0; i < array.GetLength(0); i++, k++)
    {
        if (i != minIndexes[0])
        {
            for (int j = 0, l = 0; j < array.GetLength(1); j++, l++)
                if (j != minIndexes[1])
                    newArray[k, l] = array[i, j];
                else l--;
        }
        else k--;
    }

    return newArray;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of column: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2dArray(myArray);

int[,] resizedArray = Resize(myArray);
Show2dArray(resizedArray);