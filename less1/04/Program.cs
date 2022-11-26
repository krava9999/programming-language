// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите  число от 1");
int num = Convert.ToInt32(Console.ReadLine());
int index = 0;
string allEvenNum = "Четные числа";
while (index <= num) // пока счетчик меньше вводимого числа
{
    if ((index % 2) == 0) // проверка на четное число
    {
        allEvenNum = allEvenNum + ' ' + index;
        index++;
    }
    else
    {

        index++;
    }
}
Console.WriteLine(allEvenNum); //вывод всех четных чисел