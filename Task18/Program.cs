//Задача 18: Напишите программу, которая 
// 1. по заданному номеру четверти, 
// 2. показывает диапазон возможных координат точек в этой четверти (x и y)
//


Console.WriteLine("Enter number of quarter: ");
int qnum = Convert.ToInt32(Console.ReadLine());

string range = Range(qnum);
Console.WriteLine(range);


string Range(int num)
{
    if(num == 1) return "X > 0 and Y > 0";
    if(num == 2) return "X < 0 and Y > 0";
    if(num == 3) return "X < 0 and Y < 0";
    if(num == 4) return "X > 0 and Y < 0";
    return "Incorrect number of quarter";
}



// Console.WriteLine("Введите номер четверти");
// int number = Convert.ToInt32(Console.ReadLine());

// string range = Range(number);
// Console.WriteLine(range);

// string Range(int num)
// {
// if (num == 1) return "x > 0, y > 0";
// if (num == 2) return "x < 0, y > 0";
// if (num == 3) return "x < 0, y < 0";
// if (num == 4) return "x > 0, y > 0";
// return "нет такой четверти";
// }