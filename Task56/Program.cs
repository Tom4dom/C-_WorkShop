// Задача 56: 

// 1. Задайте прямоугольный двумерный массив. 
// 2. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка





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


int[] SumOfRowElementsOfMatrix(int[,] matrix)
{
    int[] resArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            resArray[i] += matrix[i, j];
        }
    }
    return resArray;
}


(string text, int minRowValue) FindMinimalSumRowElem(int[,] matrix, int[] arr)
{
    

    (string text, int minRowValue) result = (text: String.Empty, minRowValue: 0);
    int min = arr[result.minRowValue];

    result.text = $" The sum of the elements of the 0 row : {arr[0],3}\n";
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            result.minRowValue = i;
        }
        result.text += $" The sum of the elements of the {i} row : {arr[i],3}\n";
    }
    result.text = $" {result.minRowValue} the row with the smallest sum of elements\n\n" + result.text;
    return result;
}


int rows = 4;
int columns = 4;
int min = 0;
int max = 9;
int[,] myTwoDemArray = TwoDimensionArrayCreator(rows, columns, min, max);
ArrayPrinter(myTwoDemArray);
int[] sumOfRowElements = SumOfRowElementsOfMatrix(myTwoDemArray);
var answer = FindMinimalSumRowElem(myTwoDemArray, sumOfRowElements);
Console.WriteLine();
Console.WriteLine(answer.text);



