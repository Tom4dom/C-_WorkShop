// Задача 21:
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5,0); B(1,-1,9)  -> 11.53


int InsertPositon(string text)
{
    Console.WriteLine(text);
    int pos = Convert.ToInt32(Console.ReadLine());
    return pos;
}


double LenghtLine(int xpos1, int xpos2, int ypos1, int ypos2, int zpos1, int zpos2)
{
    int temp = (xpos1 - xpos2) * (xpos1 - xpos2) + (ypos1 - ypos2) * (ypos1 - ypos2) + (zpos1 - zpos2) * (zpos1 - zpos2);
    return Math.Sqrt(temp);
}


int x1 = InsertPositon("Enter the coordinate of the point A (X-axis): ");
int y1 = InsertPositon("Enter the coordinate of the point A (Y-axis): ");
int z1 = InsertPositon("Enter the coordinate of the point A (Z-axis): ");

int x2 = InsertPositon("Enter the coordinate of the point B (X-axis): ");
int y2 = InsertPositon("Enter the coordinate of the point B (Y-axis): ");
int z2 = InsertPositon("Enter the coordinate of the point B (Z-axis): ");


double res = LenghtLine(x1, x2, y1, y2, z1, z2);

double resRound = Math.Round(res, 2, MidpointRounding.ToZero);

Console.WriteLine($"The distance between points A and B is {resRound}");












// Console.WriteLine("Enter point A coordinates: ");
// Console.Write("AX: ");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.Write("AY: ");
// int ay = Convert.ToInt32(Console.ReadLine());
// Console.Write("AZ: ");
// int az = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter point B coordinates: ");
// Console.Write("BX: ");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.Write("BY: ");
// int by = Convert.ToInt32(Console.ReadLine());
// Console.Write("BZ: ");
// int bz = Convert.ToInt32(Console.ReadLine());

// double resultRes = Math.Round(Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by) + (az - bz) * (az - bz)), 2, MidpointRounding.ToZero);

// Console.WriteLine(resultRes);


