// Задача 35: 
// 1. Задайте одномерный массив из 123 случайных чисел.
// 2. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

//=============================================================================MyVision=================================


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write(array[i] + ",");
        else System.Console.Write(array[i]);
    }
    System.Console.WriteLine("]");
}

int FindNumbersFromRange(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            counter++;
        }

    }
    return counter;
}


int[] arr = CreateArrayRndInt(5, 0, 200);
PrintArray(arr);
int quantityOfNumbers = FindNumbersFromRange(arr);

Console.WriteLine(quantityOfNumbers);





//=============================================================================LectureVision=================================


// int[] CreatArray(int arraySize, int arrayMinValue, int arrayMaxValue)//Метод генерации массива со случайными элементами
// {
//     int[] resArray = new int[arraySize];
//     Random rnd = new Random();
//     for (int i = 0; i < resArray.Length; i++)
//     {
//         resArray[i] = rnd.Next(arrayMinValue, arrayMaxValue + 1);
//     }
//     return resArray;
// }


// string ArrayToString(int[] array)//Метод преобразования массива в строку
// {
//     string result = "[";
//     for (int i = 0; i < array.Length; i++)
//     {
//         result = result + $" {array[i]}";
//         result = i < (array.Length - 1) ? result = result + "," : result;//для корректности вывода запятых
//     }
//     return result + " ]";
// }


// int CountElements(int[] array, int fMin, int fMax)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= fMin && array[i] <= fMax) result++;
//     }
//     return result;
// }


// int arraySize = 5, arrayMinValue = 0, arrayMaxValue = 123, findMin = 10, findMax = 99;

// int[] newArray = CreatArray(arraySize, arrayMinValue, arrayMaxValue); //генерируем массив с указаными параметры
// string strArray = ArrayToString(newArray);// переводим строку в массив для дальнейшего вывода на экран

// int count = CountElements(newArray, findMin, findMax);
// Console.WriteLine($"{strArray} -> {count}");