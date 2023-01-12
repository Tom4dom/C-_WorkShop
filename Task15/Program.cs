// Задача 15:
// Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели,
// 2. и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter the day of the week by digit (from 1 to 7): ");
int day = Convert.ToInt32(Console.ReadLine());

DayWeekNum(day);

void DayWeekNum(int arg0)
{
    if (arg0 > 7 || arg0 < 1)
    {
        Console.WriteLine("Incorrect number");
    }
    if (arg0 >=1 && arg0 <= 5) /*if (arg0 == 1 || arg0 == 2 || arg0 == 3 || arg0 == 4 || arg0 == 5)*/
    {
        Console.WriteLine($"{arg0} -> no");
    }
    if (arg0 == 6 || arg0 == 7)
    {
        Console.WriteLine($"{arg0} -> yes");
    }
}



