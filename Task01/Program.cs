// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет



//My vision of this program:
// Console.WriteLine("Input integer 'A': ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input integer 'B': ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// int numberC = numberA / numberB;

// if (numberB == numberC)
// {
//     Console.WriteLine($"Yes! It is true that {numberA} is a square of {numberB}");
// }
// else
// {
//     Console.WriteLine($"No! It is not true that {numberA} is a square of {numberB}");
// }



//Classmates vision:
Console.WriteLine("Input integer 'A': ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input integer 'B': ");
int B = Convert.ToInt32(Console.ReadLine());

if (A == B * B)
{
    Console.WriteLine($"Yes! It is true that {A} is a square of {B}");
}
else
{
    Console.WriteLine($"No! It is not true that {A} is a square of {B}");
}