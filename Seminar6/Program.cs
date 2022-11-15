//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)


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

void ReverseArray(int[] array){
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    //variant 2
    /*for (int i = 0, j = array.Length -1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }*/
}
Console.Write("Input number of elements: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(number, min, max);
ShowArray(myArray);

//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
void Fibonacchi (int size, int a, int b){
    int[]array = new int[size];
    array[0] = a;
    array[1] = b;

    for (int i = 2; i < size; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
}
*/
//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CopyArray (int[] array){

    int [] newArr = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
        newArr[i] = array[i];
    
    return newArr;
}
//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

bool Triangle(int a, int b, int c){
    /*
    if (a < b + c && b < a + c && c < a + b)
        return true;
    return false; */
    return a < b + c && b < a + c && c < a + b;
}

Console.Write("Input the first side: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second side: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third side: ");
int l = Convert.ToInt32(Console.ReadLine());
bool r = Triangle(n, m, l);
Console.Write(r);