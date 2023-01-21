// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да 





//=====================================MyVision===============================================================

int[] ArrayCreator(int size, int min, int max)
{
    int[] nameOfArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < nameOfArray.Length; i++)
    {
        nameOfArray[i] = rnd.Next(min, max + 1);
    }
    return nameOfArray;
}

void ArrayPrinter(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

bool SpecificNumberInArray(int[] collection, int specialNum)
{
    for (int i = 0; i < collection.Length; i++)
    {
        if (specialNum == collection[i])
        {
            return true;
        }
    }
    return false;
}



Console.Write("Enter a number to search in the array ");
int specialNumber = Convert.ToInt32(Console.ReadLine());
int[] array = ArrayCreator(12, 1, 10);
Console.Write($"Number {specialNumber} in the array: ");
ArrayPrinter(array);

bool trueFalse = SpecificNumberInArray(array, specialNumber);
Console.Write(trueFalse);


//==============================================LectureVision===============================================


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

// bool FindNumber(int[] array, int number)
// {
// for (int i = 0; i < array.Length; i++)
// {
// if (array[i] == number) return true;
// }
// return false;
// }

// int[] arr = CreateArrayRndInt(5, 0, 10);
// PrintArray(arr);
// System.Console.WriteLine("Введите искомое число: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindNumber(arr, numb) ? "да" : "нет");


