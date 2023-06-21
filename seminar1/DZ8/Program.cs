// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число N: ");
string strA = Console.ReadLine();
int a = Convert.ToInt32(strA);
int ch = 1;
Console.Write("Четные числа до N:");
while (ch <= a)
{
    if (ch % 2 == 0)
    {

        Console.Write($" {ch}");
    }
    ch++;
}