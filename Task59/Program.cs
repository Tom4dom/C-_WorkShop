// Задача 59: 
// 1. Задайте двумерный массив из целых чисел.
// 2. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:

// 9 2 3
// 4 2 4
// 2 6 7


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

(int row, int column, int minValue) MinValueElementFinder(int[,] matrix)
{
    int minValueRow = 0;
    int minValueColumn = 0;
    int minValue = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minValue > matrix[i, j])
            {
                minValue = matrix[i, j];
                minValueRow = i;
                minValueColumn = j;
            }
        }
    }
    return (minValueRow, minValueColumn, minValue);
}


int[,] MinValueCrossRemover(int[,] matrix, int iMinRow, int jMinColumn)
{
    int[,] croppedArray = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int r = 0;
    int c = 0;
    for (int i = 0; i < croppedArray.GetLength(0); i++)
    {
        if (r == iMinRow) r++;
        for (int j = 0; j < croppedArray.GetLength(1); j++)
        {
            if (c == jMinColumn) c++;
            croppedArray[i, j] = matrix[r, c];
            c++;
        }
        r++;
        c = 0;
    }
    return croppedArray;
}

int rows = 4;
int columns = 4;
int min = -10;
int max = 10;
int[,] myTwoDemArray = TwoDementionalArrayCreator(rows, columns, min, max);
ArrayPrinter(myTwoDemArray);

var minValueElement = MinValueElementFinder(myTwoDemArray);
Console.WriteLine();
Console.WriteLine($"{minValueElement.row, 2}" + "\n" + $"{minValueElement.column, 2}" + "\n" + $"{minValueElement.minValue, 2}");

int[,] trancatedArray = MinValueCrossRemover(myTwoDemArray, minValueElement.row, minValueElement.column);
Console.WriteLine();
ArrayPrinter(trancatedArray);












//========================================================================================











// //метод создания двумерного массива из псевдочисел
// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// //метод вывода двумерного массива в консоль
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
//             else Console.Write($"{matrix[i, j],5} ");
//         }
//         Console.WriteLine("]");
//     }
// }

// (int row, int column, int minValue) minValueElementMatrix(int[,] matr)
// {
//     int minValueRow = 0;
//     int minValueColumn = 0;
//     int minValue = matr[0, 0];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (minValue > matr[i, j])
//             {
//                 minValue = matr[i, j];
//                 minValueRow = i;
//                 minValueColumn = j;
//             }
//         }
//     }
//     return (minValueRow, minValueColumn, minValue);
// }

// int[,] RemoveRowColumnCross(int[,] matrix, int iMin, int jMin)
// {
//     int[,] croppedArray = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
//     int m = 0;
//     int n = 0;
//     for (int i = 0; i < croppedArray.GetLength(0); i++)
//     {
//         if (m == iMin) m++;
//         for (int j = 0; j < croppedArray.GetLength(1); j++)
//         {
//             if (n == jMin) n++;
//             croppedArray[i, j] = matrix[m, n];
//             n++;
//         }
//         m++;
//         n = 0;
//     }
//     return croppedArray;
// }

// int[,] array2D = CreateMatrixRndInt(4, 4, 5, 9);
// PrintMatrix(array2D);
// var minValueElement = minValueElementMatrix(array2D);
// Console.WriteLine();
// Console.WriteLine(minValueElement.row + "\n" + minValueElement.column + "\n" + minValueElement.minValue);
// int[,] resMatrix = RemoveRowColumnCross(array2D, minValueElement.row, minValueElement.column);
// Console.WriteLine();
// PrintMatrix(resMatrix);