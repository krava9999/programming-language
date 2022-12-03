// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int leftPart;
int rigthPart;
if ((num >= 10000 && num <= 99999) || (num <= -10000 && num >= -99999))
{
    leftPart = num / 1000;// Откидываем всю левую часть от центра включительно
    rigthPart = num % 100;// Откидываем всю правую часть от центра включительно
    rigthPart = (rigthPart % 10) * 10 + rigthPart / 10; // разворачиваем правую часть
    if (leftPart == rigthPart)
    {
        Console.WriteLine($"число {num} палиндром");
    }
    else
    {
        Console.WriteLine($"Число  {num} не палиндром  ");
    }

}
else
{
    Console.WriteLine("Число не пятизначное ");

}