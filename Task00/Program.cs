// 0. Демонстрация решения
// Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдаёт его квадрат (число
// умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
// string str = Console.ReadLine(); ///// asfasfdlsaf 23423423

// Console.WriteLine("Insert integer and press Enter:");
// int number = Convert.ToInt32(Console.ReadLine());
// // int number1 = int.Parse(Console.ReadLine());
// int square = number * number;
// Console.WriteLine($"Square of {number} = {square}");

Console.WriteLine("Insert integer and press Enter:");
string str = Console.ReadLine();
int number = Convert.ToInt32(str);
int square = number * number;
Console.WriteLine($"The square of {number} = {square}");


