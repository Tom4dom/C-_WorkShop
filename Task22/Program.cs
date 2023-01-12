// Задача 22: Напишите программу, которая 
// 1. принимает на вход число (N) 
// 2. и выдаёт таблицу квадратов чисел от 1 до N.
// 
// 5 ->
// 1    1
// 2    4
// 3    9
// 4    16
// 5    25

// 5 -> 1,4,9,16,25
// 2 -> 1,4


Console.Write("Enter a natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

Table(number);

void Table(int num)
{
    int start = num - (num - 1);
    while (start <= num)
    {
        int square = start * start;
        start++;
        Console.WriteLine($"{start-1} -> {square}");
    }
    
}


// =======================================Класс=======================

// // Задача 22: Напишите программу, которая
// // принимает на вход число (N) и выдаёт таблицу
// // квадратов чисел от 1 до N.

// void Numb(int n1)
// {
// int counter = 1;
// while(counter <= n1)
// {
// Console.WriteLine($"{counter, 3} {counter * counter, 3}");
// counter++;
// }
// }

// System.Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// while(number < 1)
// {
// System.Console.WriteLine("Введите положительное, целое число");
// number = Convert.ToInt32(Console.ReadLine());
// }

// Numb(number);

//==================================================================




// while (start <= num)
// {
//     int write = start;
//     int square = start * start;
//     start++;
//     Console.WriteLine($"{write} -> {square}");
// }


