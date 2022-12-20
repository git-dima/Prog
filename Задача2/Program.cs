// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число!");
string value = Console.ReadLine();

Console.WriteLine("Введите второе число!");
string value2 = Console.ReadLine();

int a = int.Parse(value);
int b = int.Parse(value2);

if (a > b)
{
    Console.Write("max = " + a);
}
else
{
    Console.Write("max = " + b);
}

