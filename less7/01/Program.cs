// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] createNewArr()
{
    Console.WriteLine("Введите количество строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] doubleArr = new double[m, n];

    for (int i = 0; i < doubleArr.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArr.GetLength(1); j++)
        {
            doubleArr[i, j] = Math.Round(new Random().NextDouble(), 2);
            Console.Write($"{doubleArr[i, j]} ");
        }
        Console.WriteLine();
    }
    return doubleArr;
}


double[,] doubleArr = createNewArr();