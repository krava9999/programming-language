// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 || num <= -100)  // если число больше 100 или меньше -100, то ищем третье число
{
    while (num >= 999 || num <= -999)
    {
        num /= 10;
    }
    num %= 10;
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
