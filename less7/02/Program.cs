//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Функция создает новый массив с числами 
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
// Функция запрашивает номера строки и колонки, после чего выводит результат
void showNumArr(int[,] arr)
{
    Console.WriteLine("Введите номер строки");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца");
    int col = Convert.ToInt32(Console.ReadLine());

    if (row >= arr.GetLength(0) || row >= arr.GetLength(1))
    {
        Console.WriteLine("Такой позиции не существует");
    }
    else
    {
        Console.WriteLine($"Значение позиции: {arr[row, col]}");
    }
}

int[,] newArr = createNewArr();
showNumArr(newArr);