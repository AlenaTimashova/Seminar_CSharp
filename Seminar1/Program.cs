
// int a = 31;
// double b = -12.45;
// string c = "word";
// char d = '*';
// bool e = true;

//int a = 31;
//Console.WriteLine($"My number is {a} and it is good!");


// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

/*Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if(quad2 == n1)
{
    Console.WriteLine($"Number {n1} is square of {n2}");
}
else
{
    Console.WriteLine($"Number {n1} is not square of {n2}");
}*/

//Задача 2

/*Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.*/

/*
Console.Write("Input a positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}*/
//Задача 3. Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 10;
Console.WriteLine($"Last digit of {number} is {result}");
