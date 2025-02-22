﻿// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.

// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


int[,] TwoDementionalArrayCreator(int sizeRows, int sizeColumns, int min, int max)
{
    int[,] array = new int[sizeRows, sizeColumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}


void ArrayPrinter(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 4} ");
        }
        Console.WriteLine();
    }
}


int rows = 13;
int columns = 21;
int min = 0;
int max = 199;
int[,] myTwoDemArray = TwoDementionalArrayCreator(rows, columns, min, max);
ArrayPrinter(myTwoDemArray);





//==============================================================================================
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns]; // 0, 1
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++) // 2
{
for (int j = 0; j < matrix.GetLength(1); j++) //
{
matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3 100, 1000
}
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write("[");
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5},");
else Console.Write($"{matrix[i, j], 5} ");
}
Console.WriteLine("]");
}
}

int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);


