// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
Console.WriteLine("введите день недели");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 6:
    case 7:
        Console.WriteLine("День недели является выходным");
        break;
    default:
        Console.WriteLine("День недели НЕ является выходным");
        break;
}
