// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("введите значение для M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение для N");
int N = Convert.ToInt32(Console.ReadLine());
string result = "";

int getEvenNums(int N, int M) // В метод попадает 10
{

    if (N == M) // 
    {
        return N;
    }
    return N += getEvenNums(N - 1, M); // Возвращаем 10 передаем 9, возвращаем 9, передаем 8 ... передаем 1 
}

Console.WriteLine(getEvenNums(N, M)); // 10 

