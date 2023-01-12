// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.WriteLine("Input first number");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} greate than {b}");
}
else if (a < b)
{
    Console.WriteLine($"{a} less than {b}");
}
else
{
    Console.WriteLine ($"{a} equals {b}");
}