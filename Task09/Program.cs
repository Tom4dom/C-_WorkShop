// 9. Напишите программу, которая
// 1. выводит случайное число из отрезка [10, 99]
// 2. и показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100);

Console.WriteLine($"Random number from 10 to 99 range => {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"And the biggest digit is {firstDigit}");
// else Console.WriteLine($"And the biggest digit is {secondDigit}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;

// Console.Write($"The biggest digit of the number = {result}");
// Console.Write(firstDigit > secondDigit ? firstDigit : secondDigit);

int max = MaxDigit(number);

Console.Write($"The biggest digit of the number = {max}");



int MaxDigit(int arg)
{
    int firstDigit = arg / 10;
    int secondDigit = arg % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}