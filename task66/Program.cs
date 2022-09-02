// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в 
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


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

// int SumNaturalNumbers(int m, int n)
// {
//     int sum = DigitsSum(m);

//     int DigitsSum(int number)
//     {
//         if (number < 10)
//             return number;
//         return number % 10 + DigitsSum(number / 10);
//     }
// }

int SumNaturalNumbers(int m, int n)
{
    if (m < n)
    {
        Console.Write(m + " ");
        sum = sum + m;
        m++;
        return SumNaturalNumbers(m, n);
    }
else
    if (m > n)
    {
        Console.Write(m - " ");
        sum = sum + m;
        m--;
        return SumNaturalNumbers(m, n);
    }
}

SumNaturalNumbers(m, n);
