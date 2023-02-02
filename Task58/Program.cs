// Задача 58: 

// 1. Задайте две матрицы. 
// 2. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18


int[,] TwoDimensionArrayCreator(int sizeRows, int sizeColumns, int min, int max)
{
    int[,] matrix = new int[sizeRows, sizeColumns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void ArrayPrinter(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixProd(int[,] arr1, int[,] arr2)
{
    int tmp = 0;
    int sizeRow = arr1.GetLength(0);
    int sizeCol = arr2.GetLength(1);

    int[,] resMatrix = new int[sizeRow, sizeCol];
    for (int i = 0; i < sizeRow; i++)
    {
        for (int j = 0; j < sizeCol; j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                tmp += arr1[i, k] * arr2[k, j];
            }
            resMatrix[i, j] += tmp;
            tmp = 0;
        }
    }
    return resMatrix;
}

int rows1 = 4;
int columns1 = 4;
int min1 = 0;
int max1 = 9;
int[,] firstMatr = TwoDimensionArrayCreator(rows1, columns1, min1, max1);
Console.WriteLine();
Console.WriteLine("Matrix A:");
ArrayPrinter(firstMatr);

int rows2 = 4;
int columns2 = 4;
int min2 = 0;
int max2 = 9;
int[,] secondMatr = TwoDimensionArrayCreator(rows2, columns2, min2, max2);
Console.WriteLine();
Console.WriteLine("Matrix B:");
Console.WriteLine();
ArrayPrinter(secondMatr);


if (firstMatr.GetLength(1) != secondMatr.GetLength(0))
{
    Console.WriteLine("The matrix data cannot be multiplied.");
    Console.WriteLine("The number of rows in the first matrix is not equal to the number of columns in the second");
}
else
{
    Console.WriteLine();
    Console.WriteLine("The product of the matrices A and B:");
    Console.WriteLine();
    int[,] prod2Matrix = MatrixProd(firstMatr, secondMatr);
    ArrayPrinter(prod2Matrix);
}