// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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

int sumUnEvenPosition(int[] arrMass)
{
    int sum = 0;
    for (int i = 1; i < arrMass.Length; i = i + 2)
    {
        sum += arrMass[i];
    }
    return sum;
}

Console.Write($"Cумма элементов, стоящих на нечётных позициях{sumUnEvenPosition(arr)}");