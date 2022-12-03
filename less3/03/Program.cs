// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
double result;
string answer = String.Empty;
while (i <= num)
{
    result = Math.Pow(i, 3);
    answer = answer + result + ' ';
    i++;
}
Console.WriteLine(answer);