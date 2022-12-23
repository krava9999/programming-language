// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
Console.WriteLine("введите значение для M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение для N");
int N = Convert.ToInt32(Console.ReadLine());
string result = "";

int getSumNums(int N, int M) // В метод попадает 10
{

    if (N == M) // 
    {
        return N;
    }
    return N += getSumNums(N - 1, M); // Возвращаем 10 передаем 9, возвращаем 9, передаем 8 ... передаем 1 
}

Console.WriteLine(getSumNums(N, M)); // 10 

