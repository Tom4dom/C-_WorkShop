// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).


Console.Clear();
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"The number {num} is even");
}
else
{
Console.WriteLine($"The number {num} is not even");
}
