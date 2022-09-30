// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Clear();
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// string Recurs(int n)
//     {
//     if (n == 0) return string.Empty;
//     return n + " " + Recurs(n-1);
//     }
// Console.WriteLine(Recurs(n));


// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.Clear();
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int m = Convert.ToInt32(Console.ReadLine());

int A(int n)
// int B(int m)
{
   if (n == 0) return 0;
   return n + A(n-1);
}
Console.WriteLine(A(n));




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Console.Clear();
// Console.Write("Введите первое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Akkerman = A(m, n);

// Console.Write($"A({m},{n}) = {Akkerman} ");

// int A(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return A(m - 1, 1);
//   else return A(m - 1, A(m, n - 1));
// }

