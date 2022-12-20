// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число!");
string value = Console.ReadLine();

int a = int.Parse(value);

if (a % 2 == 0)
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}