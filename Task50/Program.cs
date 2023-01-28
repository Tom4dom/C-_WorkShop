// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4


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

int[] UsrsElementPositionRequest()
{
    int[] arr = new int[2];
    Console.WriteLine("Enter the position of the array element");
    Console.Write("   Row: ");
    arr[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Column: ");
    arr[1] = Convert.ToInt32(Console.ReadLine());
    arr[0] = arr[0] - 1;
    arr[1] = arr[1] - 1;
    return arr;
}

void ArrayElementSearch(int[,] matrix, int[] position, int sizeRows, int sizeColumns)
{
    if (position[0] < sizeRows && position[1] < sizeColumns)
    {
        int element = matrix[position[0], position[1]];
        Console.WriteLine($"Search result: {element}");
    }
    else
    {
        Console.WriteLine($"There is no such element! Try a different positon.");
    }
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


int rows = 5;
int columns = 5;
int min = -10;
int max = 10;
int[,] myTwoDemArray = TwoDementionalArrayCreator(rows, columns, min, max);
int[] rowAndColumn = UsrsElementPositionRequest();
ArrayElementSearch(myTwoDemArray, rowAndColumn, rows, columns);
ArrayPrinter(myTwoDemArray, columns);
Console.WriteLine();


//int size = matrix.GetLength(0) < matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);