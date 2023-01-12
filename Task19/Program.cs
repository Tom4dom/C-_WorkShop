// Задача 19:
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Console.WriteLine("Enter an integer: ");
// int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter an integer: ");
int num = Convert.ToInt32(Console.ReadLine());


int reverse = 0;
int temp = num;
while (num != 0)
{
    int remainder = num % 10;
    reverse = reverse * 10 + remainder;
    num /= 10;
}
if (temp == reverse)
{
    Console.WriteLine();
    Console.WriteLine($"Congratulation! The number {temp} is a palindrome!");
}
else
{
    Console.WriteLine();
    Console.WriteLine($"Sorry! The number {temp} is NOT a palindrome!");
}
