// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
Console.WriteLine("введите значение для M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение для N");
int N = Convert.ToInt32(Console.ReadLine());
string result = "";

string getEvenNums(int N, int M) // В метод попадает 10
{
    if (N == M) // 10 != 1, значит переходим ниже 
    {
        if (N % 2 == 0)
        {
            return result += N;
        }
        else return result;
    }
    if (N % 2 == 0)
    {
        return result += getEvenNums(N - 1, M) + " " + N;
    }
    return result += getEvenNums(N - 1, M); // Возвращаем 10 передаем 9, возвращаем 9, передаем 8 ... передаем 1 
}

Console.WriteLine(getEvenNums(N, M)); // 10 

