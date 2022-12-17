// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
            randomArr[i, j] = new Random().Next(0, 10);
            Console.Write($"{randomArr[i, j]} ");
        }
        Console.WriteLine();
    }
    return randomArr;
}

void arithmeticMean(int[,] arr)
{

    for (int col = 0; col < arr.GetLength(1); col++)
    {

        double n = 0;
        for (int row = 0; row < arr.GetLength(0); row++) // Увеличиваем строку 
        {
            n += arr[row, col];
        }
        Console.Write($"{Math.Round(n / arr.GetLength(0), 2)}; ");
    }
}


int[,] newArr = createNewArr();
arithmeticMean(newArr);