// Задача 51: 

// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


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

int SumOfDiagonalElements(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + matrix[i, j];
            }

        }
    }
    return sum;
}


int rows = 4;
int columns = 4;
int min = 0;
int max = 9;
int[,] myTwoDemArray = TwoDementionalArrayCreator(rows, columns, min, max);
ArrayPrinter(myTwoDemArray);
Console.WriteLine();
int sum = SumOfDiagonalElements(myTwoDemArray);
Console.WriteLine($"Sum of diagonal elements of this array of numbers is equal to {sum}");


// ================================================================

int GetSum(int[,] matrix)
{
    int sum = 0;
    int size = matrix.GetLength(0) < matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);
    for (int j = 0; j < size; j++)
    {
        sum += matrix[j, j];
    }
    return sum;
}

int[,] array2D = CreateMatrixRndInt(4, 3, -100, 100);
PrintMatrix(array2D);
int sum = GetSum(array2D);
Console.WriteLine(sum);


//==============================================================================

int SummMatrix(int[,] matrix)
{
    int summMatr = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) summMatr += matrix[i, j];
        }
    }
    return summMatr;
}

int[,] arr1 = CreatMatrixNM(5, 4, 1, 10);
int summ = SummMatrix(arr1);
PrintMatrix(arr1);
System.Console.WriteLine($"Сумма элементов главной диагонали: {summ}");
