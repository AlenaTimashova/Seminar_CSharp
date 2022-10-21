// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowQuart(int quartNum)
{
    if (quartNum >= 1 && quartNum <= 4)
    {
        if (quartNum == 1) Console.WriteLine("x > 0 and y > 0");
        else if (quartNum == 2) Console.WriteLine("x < 0 and y > 0");
        else if (quartNum == 3) Console.WriteLine("x < 0 and y < 0");
        else Console.WriteLine("x > 0 and you < 0");
    }
    else
        Console.WriteLine("Wrong number");
}

Console.Write("Input a number of quarter: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowQuart(num);*/

//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int ShowQuart(double x, double y)
// {
//     int result = 0;
//     if(x > 0 && y > 0) 
//     result = 1;
//     if(x < 0 && y > 0)
//     result = 2;
//     if(x < 0 && y < 0)
//     result = 3;
//     if(x > 0 && y < 0)
//     result = 4;
//     return result;

// }

// Console.Write("Введите координату х: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Номер четверти: {ShowQuart(num1,num2)}");

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double Distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1),2)+Math.Pow((y2-y1),2)); 
}

Console.Write("Input number for x1: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input number for y1: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input number for x2: ");
double num3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input number for y2: ");
double num4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Distance(num1,num2,num3,num4));

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void Func(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.Write(Math.Pow(index, 2) + " ");
        index++;
    }

}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Func(number);*/

