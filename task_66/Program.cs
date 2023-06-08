// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введи M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int sumNaturalNum = NaturalNum(num1, num2);
Console.WriteLine($"M = {num1}; N = {num2} -> {sumNaturalNum}");


int NaturalNum(int m, int n)
{
    if(m == n) return n;
    else return m + NaturalNum(m + 1, n);
}