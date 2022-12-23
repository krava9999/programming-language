// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] createNewArr()
{
    Console.WriteLine("Введите количество строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] randomArr = new int[m, n];

    for (int i = 0; i < randomArr.GetLength(0); i++)
    {
        for (int j = 0; j < randomArr.GetLength(1); j++)
        {
            randomArr[i, j] = new Random().Next(-10, 10);
            Console.Write($"{randomArr[i, j]} ");
        }
        Console.WriteLine();
    }
    return randomArr;
}

int[,] newArr = createNewArr();

int[,] OrderArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
    return arr;
}
void showArr(int[,] arr)
{
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            Console.Write($"{newArr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] sortArr = OrderArr(newArr);

Console.WriteLine($"\nОтсортированный массив: ");
showArr(sortArr);