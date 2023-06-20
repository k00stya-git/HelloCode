// Написать программу котрая прости ввести число и выводит номер недели
Console.Write("Ведите номер дня недели: ");
string nuberString1 = Console.ReadLine();
int number1 = Convert.ToInt32(nuberString1);

if (number1 == 1) Console.Write("Понедельник");
if (number1 == 2) Console.Write("Вторник");
if (number1 == 3) Console.Write("Среда");
if (number1 == 4) Console.Write("Четверг");
if (number1 == 5) Console.Write("Пятница");
if (number1 == 6) Console.Write("Суббота");
if (number1 == 7) Console.Write("Воскресенье");
if (number1 > 8 || number1 < 1 ) Console.Write("Нет такого дня недели");