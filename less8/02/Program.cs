// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int[,] arr = createNewArr(); // генерируем новый двумерный массив

int returnIndexMinSum(int[,] arr)
{
    int[] arrResult = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int minSum = 0; // счетчик для подсчета суммы одной строки
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            minSum += arr[i, j];
        }
        arrResult[i] = minSum; // записываем результат в массив 
        Console.WriteLine($"Промежуточный результат строки {i} = {minSum}");
    }
    Console.Write($"[{string.Join(", ", arrResult)}] \n");
    int minVal = arrResult.Min(); // получаем минимальное значение массива
    return Array.IndexOf(arrResult, minVal); // получаем индекс наименьшей строки
}
int indexMin = returnIndexMinSum(arr);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexMin}");