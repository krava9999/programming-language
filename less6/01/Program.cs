// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] newUserArr()
{
    Console.WriteLine("Сколько чисел хотите ввести?");
    int countNums = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[countNums];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());

    }
    Console.Write($"Ваш массив: [{string.Join(", ", arr)}] \n");
    return arr;

}

void showAllPlusNums(int[] arr)
{
    int countPlusNums = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= 0)
        {
            countPlusNums++;
        }
    }

    Console.Write($"Количество положительных чисел в массиве: {countPlusNums}");
}

int[] arr = newUserArr();
showAllPlusNums(arr);

