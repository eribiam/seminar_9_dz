﻿//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int AckermanFunction (int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermanFunction(m - 1, 1); 
    else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Console.Clear();
Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($" Значение функции Аккермана для чисел {m} и {n} = ");
Console.WriteLine(AckermanFunction(m, n));
