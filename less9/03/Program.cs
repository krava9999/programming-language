// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return ackermann(m - 1, 1);
    if (m > 0 && n > 0) return ackermann(m - 1, ackermann(m, n - 1));
    return ackermann(m, n);
}
Console.Write($"Результат работы функции: {ackermann(m, n)}");