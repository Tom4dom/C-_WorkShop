// 16. Напишите программу, которая
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// ======================================================================== MINE 
bool Method(int arg0, int arg1)
{
    return arg0%arg1 == 0 || arg1%arg0 == 0;
}



Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if Method((num1), (num2))
{
    Console.WriteLine("OK");
}
else
{
    Console.WriteLine("Not OK");
}




//========================================================================= НЕТ ПРОВЕРКИ НА КВАРДРАТ:
// Console.WriteLine("введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(IsSquare(number1, number2) ? "да" : "нет");

// bool IsSquare(int n1, int n2)
// {
// return n1 % n2 == 0 || n2 % n1 == 0;
// }


// ========================================================================= РАБОЧИЙ ВАРИАНТ
// Console.WriteLine("введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(IsSquare(number1, number2) ? "да" : "нет");

// bool IsSquare(int n1, int n2)
// {
// return n1 / n2 == n2 || n2 /n1 == n1;
// }