// Написать программу которая принимает число и выдает его квадрат
Console.Write("Введите число 1: ");
string nuberString1 = Console.ReadLine();
int number1 = Convert.ToInt32(nuberString1);
Console.Write("Введите число 2: ");
string nuberString2 = Console.ReadLine();
int number2 = Convert.ToInt32(nuberString2);

if (number2 * number2 == number1)
{
    Console.Write("Число 1 явлется квадратома числа 2");
}
else
{
    Console.Write("УВЫ, число 1 не явлется квадратома числа 2");
}