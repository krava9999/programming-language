//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] randomArr()
{
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальный порог случайных значений");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальный порог случайных значений");
    int max = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    Console.Write($"[{string.Join(", ", arr)}] \n");
    return arr;
}
int[] arr = randomArr();

int difference()
{
    int maxValue = arr.Max();
    int minValue = arr.Min();
    return maxValue - minValue;
}

Console.Write($"Разность минимального и максимальных значений равна {difference()}");

