using System;
using Math = System.Math;

Console.WriteLine("Hello, World!");

//Первая задача

Console.WriteLine("\nЗадача 1");


//Кол-во поездов
int t1 = 40;
int t2 = 60;
int hspeed = 3;
Console.WriteLine("\nКол-во трамваев по пути = 40");
Console.WriteLine("\nКол-во трамваев навстречу = 60");
Console.WriteLine("\nСкорость человека = 3");

//функция нахождения кратного числа
int nahod(int b, int c)
{
    int a = 1;
    while (true)
    {
        if (a % b == 0 && a % c == 0)
        {
            return a;
        }
        else
        {
            a += 1;
        }
    }
}

//находим кратное число значениям трамваев
int kratnoe = nahod(t1, t2);
int y = kratnoe / t1;
int x = kratnoe / t2;

//Средняя скорость трамваев
int tspeed;
for (tspeed = 1; tspeed <= 100; tspeed++)
{
    if (x * (tspeed + hspeed) == y * (tspeed - hspeed))
    {
        Console.WriteLine("\nОтвет: " + tspeed + "км/ч");
        break;
    }
}

Console.WriteLine("\n=======================================");
//2

Console.WriteLine("\nЗадача 2");
int[] a = { 123, 142, 125, 154, 133, 119, 148 };
int[] b = { 134, 142, 163, 127, 142, 155, 120 };

Console.WriteLine(korrel(a, b));
        
        static double korrel(int[] a, int[] b)
{
    //Считаем средние для двух выборок: X, Y (сложить все элементы выборки и разделить на их количество).
    double X = 0, Y = 0;
    double[] c = { };
    for (int i = 0; i < a.Length; i++)
    {
        X += a[i];
        Y += b[i];
    }
    X = X / a.Length;
    Y = Y / b.Length;

    //Считаем почти дисперсию Sx и Sy: суммируем квадраты отклонений(x[i] - X) ^ 2, (y[i] - Y) ^ 2
    double Sx = 0, Sy = 0;
    for (int i = 0; i < a.Length; i++)
    {
        Sx += (a[i] - X) * (a[i] - X);
        Sy += (b[i] - Y) * (b[i] - Y);
    }

    //Считаем почти коварацию CovXY: суммируем произведения отклонения X и отклонения Y(x[i] - X) * (y[i] - Y)
    for (int i = 0; i < a.Length; i++)
    {
        double CovXY = 0;
        CovXY += (a[i] - X) * (b[i] - Y);
        Console.WriteLine(CovXY);
    }
    return 0;
}