﻿// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10



// int UsrInputNums(string usrtxt)
// {
//     Console.Write(usrtxt);
//     string line = Console.ReadLine();
//     string[] splitString = line.Split(' ');
//     int num = int.Parse(splitString[0]);
//     return num;
// }

// int[] decimalToBinary(int number)
// {
//     int[] array = new int[]
// }



// int num = UsrInputNums("Enter an integer number: ");

// Console.WriteLine(num);



int ParseIn2(int num)
{
if (num == 0) return 0;
int result = num % 2;
num /= 2;
result += ParseIn2(num) * 10;
return result;
}
//Console.WriteLine(ParseIn2(Convert.ToInt32(Console.ReadLine())));
Console.WriteLine("Введите чило");
var num =Console.ReadLine();
Console.WriteLine(ParseIn2(Convert.ToInt32(num)));






// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int number = NumberInput("Please, input your number");
Console.WriteLine(DecToBin(number));

int NumberInput(string text) // Method fot Number input
{
Console.WriteLine(text);
int numberinput = Convert.ToInt32(Console.ReadLine());
return numberinput;
}

string DecToBin(int num)
{
string result = string.Empty;
while (num > 0)
{
result = num % 2 + result;
num /= 2;
}
return result;
}
