// Задача 24: 
// Напишите программу, которая
//
// 1. принимает на вход число (А) и 
// 2. выдаёт сумму чисел от 1 до А.
//
// 7 -> 28      1+2+3+4+5+6+7
// 4 -> 10      1+2+3+4
// 8 -> 36      1+2+3+4+5+6+7+8


// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int temp = num;
// int sum = num;


// while (num >= 1)
// {
//     num = num - 1;
//     sum = sum + num;
// }

// Console.WriteLine($"{temp} -> {sum}");


// Console.Write("Input a number: ");
// int num = int.Parse(Console.ReadLine());

// int temp = num;
// int sum = num;


// while (num >= 1)
// {
//     num = num - 1;
//     sum = sum + num;
// }

// Console.WriteLine($"{temp} -> {sum}");



// Console.Write("Input a number: ");
// int num = int.Parse(Console.ReadLine());
// //int num = Convert.ToInt32(Console.ReadLine());

// //int sumOfNum = SumOfNum(num);

// Console.WriteLine($"{num} -> {SumOfNum(num)}");


// int SumOfNum(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= number; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }





// int SumOfNum(int number)
// {
//     int sum = 0;
//     int i = 1;
//     while (i <= number)
//     {
//         sum = sum + i;
//         i++;
//     }
//     return sum;
// }




Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int sumOfNumbers = SumOfNumbers(number);

Console.WriteLine($"Sum of numbers from 1 to {number} equals {sumOfNumbers}");

int SumOfNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}