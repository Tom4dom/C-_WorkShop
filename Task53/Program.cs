// Задача 53: 
// 1. Задайте двумерный массив. 
// 2. Напишите программу, которая поменяет местами первую и последнюю строку массива.


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

void RowChanger(int[,] arr)
{
    int[] temp = new int[arr.GetLength(1)];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = arr[0, i];
    }

    for (int i = 0; i < temp.Length; i++)
    {
        arr[0, i] = arr[arr.GetLength(0)-1, i];
    }

   for (int i = 0; i < temp.Length; i++)
    {
        arr[arr.GetLength(0)-1, i] = temp[i];
    }
}



int rows = 4;
int columns = 5;
int min = 0;
int max = 9;
int[,] myTwoDemArray = TwoDementionalArrayCreator(rows, columns, min, max);
ArrayPrinter(myTwoDemArray);

RowChanger(myTwoDemArray);
Console.WriteLine();
ArrayPrinter(myTwoDemArray);