// Задача 55: 
// 1. Задайте двумерный массив. 
// 2. Напишите программу, которая заменяет строки на столбцы. 
// 3. В случае, если это невозможно, программа должна вывести сообщение для пользователя.


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

void ReplaceRowsColumns(int[,] matr)
{
    if (matr.GetLength(0) == matr.GetLength(1))
    {
        int temp = 0;
        for (int i = 1; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                temp = matr[i, j];
                matr[i, j] = matr[j, i];
                matr[j, i] = temp;
            }
        }
        ArrayPrinter(matr);
    }

    else
    {
        Console.WriteLine("impossible");
    }
}

int rows = 4;
int columns = 4;
int min = 0;
int max = 9;
int[,] myTwoDemArray = TwoDementionalArrayCreator(rows, columns, min, max);
ArrayPrinter(myTwoDemArray);
Console.WriteLine();
ReplaceRowsColumns(myTwoDemArray);




//=============================================================================================

// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

//метод создания двумерного массива из псевдочисел

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

// void ReplaceRowsColumns(int[,] matr)
// {
//     int temp = 0;
//     for (int i = 1; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < i; j++)
//         {
//             temp = matr[i, j];
//             matr[i, j] = matr[j, i];
//             matr[j, i] = temp;
//         }
//     }
// }

// // 5 2 3 8 1
// // 6 0 4 3 5
// // 8 3 1 0 6
// // 9 5 1 5 7
// // 0 5 3 8 7


// int[,] array2D = CreateMatrixRndInt(4, 4, -10, 10);
// PrintMatrix(array2D);
// Console.WriteLine();

// if (array2D.GetLength(0) == array2D.GetLength(1))
// {
//     ReplaceRowsColumns(array2D);
//     PrintMatrix(array2D);
// }
// else Console.WriteLine("impossible");