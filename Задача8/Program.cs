// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5-> 2, 4
// 8-> 2, 4, 6, 8

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число!");
        string value = Console.ReadLine();

        int a = int.Parse(value);
        int b = 0;

        if (a % 2 != 0)
        {
            a = a - 1;
        }

        do
        {
            b = b + 2;
            Console.Write(b + ", ");
        }
        while (b < a - 2);
        Console.Write(b + 2);
    }
}

// Последние строчки сделаны для того,
// чтобы избавиться от запятой в конце ответа, выводимого на экран.