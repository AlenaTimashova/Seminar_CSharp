//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int FindSum (int number){

    int result = 0;
    for (int current = 1; current <= number; current++)
    {
        result += current;
    }
    return result;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers from 1 to {num} is {FindSum(num)}");*/

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int CountDigits (int number){
    int count = 0;
    
    if(number == 0){
        return 1;
    
    while (number != 0 ){
        number = number / 10;
        count++;
    } 
    return count;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"There are {CountDigits(num)} in {num}");*/

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int FindMult (int number){

    int result = 1;
    for (int current = 1; current <= number; current++)
    {
        result *= current;
    }
    return result;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Multiple of {num} is {FindMult(num)}");*/

//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


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