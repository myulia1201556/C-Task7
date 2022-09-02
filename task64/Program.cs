﻿// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"
 
Console.WriteLine("Введите целое положительное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int m, int n)
{
	if (m == n)
	{
		Console.Write($"{m}");
		return;
	}
	Console.Write($"{m}, ");

	if (m > n)
		NaturalNumbers(m - 1, n);
	else if (m < n)
		NaturalNumbers(m + 1, n);
}

NaturalNumbers(m, n);
