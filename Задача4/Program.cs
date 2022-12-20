// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите первое число!");
string value = Console.ReadLine();

Console.WriteLine("Введите второе число!");
string value2 = Console.ReadLine();

Console.WriteLine("Введите второе число!");
string value3 = Console.ReadLine();

int a = int.Parse(value);
int b = int.Parse(value2);
int c = int.Parse(value3);

if (a > b && a > c)
{
    Console.Write(a);
}
else if (b > a && b > c)
{
    Console.Write(b);
}
else
{
    Console.Write(c);
}