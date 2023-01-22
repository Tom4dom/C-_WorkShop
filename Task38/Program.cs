// Задача 38:

// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1, MidpointRounding.ToZero);
    }
    return array;
}


void PrintArrayDouble(double[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + "; ");
        else Console.Write(array[i]);
    }

    Console.Write("]");
}

double[] MinMax(double[] arr)
{   
    double max = arr[0];
    double min = arr[0];
    double[] minMax = new double[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= max)
        {
            max = arr[i];
            minMax[1] = max;
        }
    }
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= min)
        {
            min = arr[i];
            minMax[0] = min;
        }
    }

    return minMax;
}




int arraySize = 7, arrayMinValue = 1, arrayMaxValue = 10;

double[] array = CreateArrayRndDouble(arraySize, arrayMinValue, arrayMaxValue);
PrintArrayDouble(array);
double[] minMax = MinMax(array);
double difference = minMax[1] - minMax[0];
double round = Math.Round(difference, 2, MidpointRounding.ToZero);
Console.Write($" - > {round}");

