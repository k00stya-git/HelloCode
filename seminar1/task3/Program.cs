// Программа которая принимает цело число и выводит диапазон чисел от этого числа с отрицательным знаком до самого числа
Console.Write("Введите целое число: ");
string str = Console.ReadLine();
int chislo = Convert.ToInt32(str);
for (int i = -chislo; i<=chislo; i++)
{
    Console.Write(i);
    Console.Write(" ");
}

