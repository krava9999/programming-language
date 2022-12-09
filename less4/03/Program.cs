
// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).
// Реализовать через функции.
// (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)

Console.WriteLine("Введите количесиво элементов в массиве");
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
Console.WriteLine("Введите минимальный порог случайных значений");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный порог случайных значений");
int max = Convert.ToInt32(Console.ReadLine());
getArray(a, min, max);
void getArray(int a, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
        Console.WriteLine(arr[i]);
    }
    Console.Write($"[{string.Join(", ", arr)}]");
}

