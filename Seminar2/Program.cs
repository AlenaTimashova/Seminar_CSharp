/*int CutDigit(int number)
{
    int ed = number % 10;
    int sot = number / 100;
    int result = sot*10 + ed;
    return result;
}
int randNum = new Random().Next(100, 1000);
int newNum = CutDigit(randNum);

Console.WriteLine($"new version of {randNum} is {newNum}");*/

/*Задача 1
int BigNum(int number)
{
 int ed = number % 10;
 int des = number / 10;
 
 if(ed > des) 
 return ed;
 
 else
 return des;
}
int randNum = new Random().Next(10, 100);
int bigNum = BigNum(randNum);
Console.WriteLine(randNum + " " + bigNum);*/

//Задача 2
/*
bool Square(int number1, int number2)
{
    if(number1*number1 == number2 || number2*number2 == number1)
    return true;
    else 
    return false; 
}

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
bool result = Square(a, b);
Console.WriteLine(result);*/

//Задача 3
/*
bool Mult(int num1, int num2)
{
    if (num2 % num1 == 0)
    return true;
    else
    return false;
}

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
bool result = Mult(a, b);
Console.WriteLine(result); */

//Задача 4.

bool Kratnoe(int a, int m, int n)
{
    if (a % m == 0 && a % n == 0)
        return true;
    else
        return false;
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Kratnoe(num1, num2, num3));