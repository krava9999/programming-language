// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.
Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
sumAllNum(a);
void sumAllNum(int a)
{
    int sum = 0;
    while (a >= 0)
    {
        sum += a;
        a--;
    }
    Console.WriteLine(sum);
}
