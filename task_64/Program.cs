﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(N);

void NaturalNumbers(int n) 
{
    Console.Write($"{n} ");
    if (n == 1) return;
    NaturalNumbers (n - 1);
}