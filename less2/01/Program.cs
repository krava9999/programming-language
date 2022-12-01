// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки
Console.WriteLine("Введите трех значное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999)
{
    num %= 100;
    num /= 10;
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Число не трех значное");
}

