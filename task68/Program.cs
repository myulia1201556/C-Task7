// Задача 68: Напишите программу 
// вычисления функции Аккермана
//  с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.WriteLine("Введите целое положительное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0)
{
    Console.WriteLine("Неверный ввод, попробуйте снова");
}
else if (n < 0)
{
    Console.WriteLine("Неверный ввод, попробуйте снова");
}

int functionAkkerman = Ack(m, n);
Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}