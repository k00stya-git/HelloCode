// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Введите целое число: ");
string strA = Console.ReadLine();
int a = Convert.ToInt32(strA);
Console.Write("Введите целое число: ");
string strB = Console.ReadLine();
int b = Convert.ToInt32(strB);
if (a<=b)
{
    if (a==b)
    {
        Console.Write("Числа равны");
    }
    else
    {
        Console.Write($"MAX: {b}");
        Console.Write($", MIN: {a}");
    }
}
else
{
    Console.Write($"MAX: {a}");
    Console.Write($", MIN: {b}");
}