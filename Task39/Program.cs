// Задача 39: Напишите программу, которая 
// 1. перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)


// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]




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

int[] ArrayMirrorer(int[] collection)
{
    int size = collection.Length;
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = collection[size - 1];
        size = size-1;
    }
    return array;
}

void ArrayMirrorerSecondIteration(int[] collection)
{
    for (int i = 0; i < collection.Length/2; i++)
    {
        int temp = collection[i];
        collection[i] = collection[collection.Length - 1 - i];
        collection[collection.Length - 1 - i] = temp;

    }
}




int arraySize = 7, arrayMinValue = 1, arrayMaxValue = 9;

int[] array = RandomNumbersArrayCreator(arraySize, arrayMinValue, arrayMaxValue);
ArrayPrinter(array);
Console.WriteLine();
int[] mirroredArray = ArrayMirrorer(array);
ArrayPrinter(mirroredArray);
Console.WriteLine();
Array.Reverse(mirroredArray);
ArrayPrinter(mirroredArray);
Console.WriteLine();
Console.WriteLine();
ArrayMirrorerSecondIteration(array);
ArrayPrinter(array);


