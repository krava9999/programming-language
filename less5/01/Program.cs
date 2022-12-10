//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] randomArr()
{
    Console.WriteLine("Введите размер массива");
    int a = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[a];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    Console.Write($"[{string.Join(", ", arr)}] \n");
    return arr;
}
int[] arr = randomArr();

int countEvenNumsInArr(int[] arrMass)
{
    int countEvenNums = 0;
    for (int i = 0; i < arrMass.Length; i++)
    {
        if (arrMass[i] % 2 == 0)
        {
            countEvenNums++;
        }
    }
    return countEvenNums;
}

Console.Write($"Количество четных чисел в массиве {countEvenNumsInArr(arr)}");
