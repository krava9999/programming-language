// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double getNum(double num = 0)
{
    Console.WriteLine("Введите координату");
    return num = Convert.ToInt32(Console.ReadLine());
}

string getDot(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    Console.WriteLine($"{x}");
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    string dot = $"({y1}):({y2})";
    return dot;
}
double k1 = getNum();

double b1 = getNum();

double k2 = getNum();

double b2 = getNum();



Console.WriteLine($"Точки пересечения {getDot(b1, b2, k1, k2)}");