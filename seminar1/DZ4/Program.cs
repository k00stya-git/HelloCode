// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите первое число: ");
string strA = Console.ReadLine();
int a = Convert.ToInt32(strA);

Console.Write("Введите второе число: ");
string strB = Console.ReadLine();
int b = Convert.ToInt32(strB);

Console.Write("Введите третье число: ");
string strC = Console.ReadLine();
int c = Convert.ToInt32(strC);

int max = a;

if (b > a) max=b;
if (c > b) max=c;

Console.Write($"Максимальное число: {max}");