// 14. Напишите программу, которая 
// 1. принимает на вход число и 
// 2. проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да


bool Method(int arg0)
{
    return arg0 % 7 == 0 && arg0 % 23 == 0;
}


Console.WriteLine("Input an integer: ");
int num = Convert.ToInt32(Console.ReadLine());

if(Method (num))
{
    Console.WriteLine($"{num} is divisible to 7 and 23");
}
else
{
    Console.WriteLine($"{num} is not divisible to 7 and 23 at the same time");
}