// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21









Console.WriteLine("Enter point A coordinates: ");
Console.Write("AX: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("AY: ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter point B coordinates: ");
Console.Write("BX: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("BY: ");
int by = Convert.ToInt32(Console.ReadLine());

double resultRes = Math.Round(Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by)), 2, MidpointRounding.ToZero);

Console.WriteLine(resultRes);


// double lengthAb = LengthAB(ax, ay, bx, by);

// double LengthAB(double ax, double ay, double bx, double by)
// {
//     double sumSquareOfLegs = (ax - bx) * (ax - bx) + (ay - by) * (ay - by);
//     double result = Math.Sqrd(sumSquareOfLegs);
//     double resultRes = Math.Round(result, 2, MidpointRounding.ToZero);
// }












// double noref = Math.Pow(2);
// Console.Write(noref);

// double d = Math.Sqrt(41);
// // double d = 5.09986564;
// double dRes = Math.Round(d, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(dRes);




// int InsertPositon(string text)
// {
// Console.WriteLine(text);
// int pos = Convert.ToInt32(Console.ReadLine());
// return pos;
// }

// int x1 = InsertPositon("Введите координату Х первой точки:");
// int y1 = InsertPositon("Введите координату Y первой точки:");

// int x2 = InsertPositon("Введите координату Х второй точки:");
// int y2 = InsertPositon("Введите координату Y второй точки:");

// double LenghtLine(int xpos1, int xpos2, int ypos1, int ypos2)
// {
// int temp = (xpos1-xpos2)*(xpos1-xpos2) + (ypos1-ypos2)*(ypos1-ypos2);
// return Math.Sqrt(temp);
// }

// double res = LenghtLine(x1,x2,y1,y2);

// double resRound = Math.Round(res,2,MidpointRounding.ToZero);

// Console.WriteLine($"Растояние между точками равно :{resRound}");

