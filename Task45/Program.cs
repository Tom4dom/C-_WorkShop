// Задача 45: 
// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. 


int[] RandomNumbersArrayCreator(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}


void ArrayPrinter(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + "; ");
        else Console.Write(array[i]);
    }

    Console.Write("]");
}

int[] ArrayCopier(int[] collection)
{
    int size = collection.Length;
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = collection[i];
        
    }
    return array;
}
int arraySize = 7, arrayMinValue = 1, arrayMaxValue = 9;

int[] array = RandomNumbersArrayCreator(arraySize, arrayMinValue, arrayMaxValue);
ArrayPrinter(array);
Console.WriteLine();
int[] copyOfArray = ArrayCopier(array);
ArrayPrinter(copyOfArray);
Console.WriteLine();








// //=========================================================================================
// // Задача 45: Напишите программу, которая будет создавать
// // копию заданного массива с помощью поэлементного
// // копирования.

// int[] arr1 = CreateArrayRndInt(7, 1, 9);
// int[] arr2 = CopyArray(arr1);
// PrintArray(arr1);
// PrintArray(arr2);

// // Создание рандомного массива int
// int[] CreateArrayRndInt(int size, int min, int max)
// {
// int[] array = new int[size];
// Random rnd = new Random();
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = rnd.Next(min, max + 1);
// }
// return array;
// }

// // Печать массива int
// void PrintArray(int[] array)
// {
// System.Console.Write("[");
// for (int i = 0; i < array.Length; i++)
// {
// if (i < array.Length - 1) System.Console.Write(array[i] + ",");
// else System.Console.Write(array[i]);
// }
// System.Console.WriteLine("]");
// }

// // Копия массива int
// int[] CopyArray(int[] input)
// {
// int[] result = new int[input.Length];
// for (int i = 0; i < input.Length; i++)
// {
// result[i] = input[i];
// }
// return result;
// }

