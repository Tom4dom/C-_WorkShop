// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] TwoDementionalArrayCreator(int sizeRows, int sizeColumns, int min, int max)
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

void ArrayPrinter(int[,] matrix, int col)
{
    int columnsMarkings = 1;
    for (int i = 0; i < col; i++)
    {
        Console.Write($"===={columnsMarkings}===");
        columnsMarkings++;
    }
    Console.WriteLine();

    int rowMarkings = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{rowMarkings,2}|");
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

void ArithmeticMeanOfEashColumn(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    double sumToAvg = 0;
    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            sumToAvg = sumToAvg + arr[i, j];
        }
        sumToAvg = Math.Round(sumToAvg / rows, 2);
        Console.Write($" {sumToAvg, 6} ");
    }
}


int rows = 5;
int columns = 5;
int min = -10;
int max = 10;
int[,] myTwoDemArray = TwoDementionalArrayCreator(rows, columns, min, max);
ArrayPrinter(myTwoDemArray, columns);
ArithmeticMeanOfEashColumn(myTwoDemArray);