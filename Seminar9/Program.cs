// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Рекурсия
/*
void ShowNums(int n)
{
    if(n > 1) ShowNums(n-1);
    Console.WriteLine(n + " ");
}

ShowNums(5);
*/

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumOfDigits(int n)
{
    if (n != 0) return SumOfDigits(n / 10) + n % 10;
    return 0;
}

Console.WriteLine(SumOfDigits(5243));
*/

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNums(int m, int n)
{
    if (m > n)
    {
        ShowNums(m, n - 1);
        Console.Write(n + " ");
    }
    else if (n > m)
    {
        Console.Write(m + " ");
        ShowNums(m + 1, n);
    }
    else
        Console.Write(m + " ");

}

ShowNums(10, 5);


// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

double CustPower(double number, double power)
{
    if (power > 0)
        return CustPower(number, power - 1) * number;
    else if (power < 0)
        return CustPower(number, power + 1) / number;
    else
        return 1;
}

Console.WriteLine(CustPower(2, 10));