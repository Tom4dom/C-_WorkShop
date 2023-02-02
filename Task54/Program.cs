// Задача 54: 
// 1. Задайте двумерный массив. 
// 2. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void TwoDimensionArraySorter(int[,] matrix)
{
    int tmp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - j; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    tmp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = tmp;
                }
            }
        }
    }
}

int rows = 4;
int columns = 4;
int min = 0;
int max = 9;
int[,] myTwoDemArray = TwoDimensionArrayCreator(rows, columns, min, max);
ArrayPrinter(myTwoDemArray);
TwoDimensionArraySorter(myTwoDemArray);
Console.WriteLine();
ArrayPrinter(myTwoDemArray);
