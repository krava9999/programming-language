//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции.

void step(int a, int b)
{
    int i = 2; int num = a;
    while (b >= 2)
    {
        a *= num;
        b--;
    }
    Console.WriteLine(a);
}


Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
step(a, b);


