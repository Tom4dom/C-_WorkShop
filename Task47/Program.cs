// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


double[,] TwoDementionalArrayCreator(int sizeRows, int sizeColumns, int min, int max)
{
    double[,] matrix = new double[sizeRows, sizeColumns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero);
        }
    }
    return matrix;
}


void ArrayPrinter(double[,] matrix, int col)
{
    int columnsMarkings = 0;
    for (int i = 0; i < col; i++)
    {
        Console.Write($"====={columnsMarkings}==");
        columnsMarkings++;   
    }
    Console.WriteLine();
    
    int rowMarkings = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{rowMarkings}|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} | ");
        }
        rowMarkings++;
        Console.WriteLine();
    }

    for (int i = 0; i < col; i++)
    {
        Console.Write($"========");
        columnsMarkings++;   
    }
    Console.WriteLine();
    
}


int rows = 3;
int columns = 4;
int min = -10;
int max = 10;
double[,] myTwoDemArray = TwoDementionalArrayCreator(rows, columns, min, max);
ArrayPrinter(myTwoDemArray, columns);