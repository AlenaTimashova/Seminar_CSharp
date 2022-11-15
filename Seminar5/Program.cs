
int[] CreateRandomArray(int size, int minValue, int maxValue){

    int[] array = new int[size];
    for (int i = 0; i <size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[]array){

    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

        Console.WriteLine();
}

Console.Write("Input number of elements: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(number, min, max);
ShowArray(myArray);


// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int GetNegativeSum (int[] array){

    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            sum += array[i];
    
    return sum;
}

int negativeSum = GetNegativeSum(myArray);
Console.WriteLine("Sum of negative numbers of the array is " + negativeSum);*/

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
bool Check(int[] array, int num){

    for (int i = 0; i < array.Length; i++)
    {
        if (num == array[i])
            return true;
    }

    return false;
}
*/
//Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int Count (int[] array, int start, int end){

    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] >= start && array[i] <= end)
            count++;
    
    return count;
}*/