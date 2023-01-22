// Задача 37: 
// 
// 1. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// 2. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

//======================================================================MyVision===========================================================

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write(array[i] + ",");
//         else Console.Write(array[i]);
//     }
//     Console.WriteLine("]");
// }

// int[] PairOfNumbers(int[] collection)
// {
//     int size = collection.Length % 2 != 0 ? collection.Length / 2 + 1: collection.Length / 2;
//     Console.WriteLine($"size = {size}");
//     int anotherEndOfArray = collection.Length;
//     Console.WriteLine($"Variable anotherEndOfArray is now {anotherEndOfArray}");
//     int[] pairs = new int[size];
//     PrintArray(pairs);
//     Console.WriteLine($"Collection.Length = {size}");
//     Console.WriteLine($"anotherEndOfArray = {anotherEndOfArray}");
//     for (int i = 0; i < size; i++)
//     {
//         pairs[i] = collection[i] + collection[anotherEndOfArray];
//         anotherEndOfArray = anotherEndOfArray - 1;
//         Console.WriteLine($"anotherEndOfArray -1 = {anotherEndOfArray}");
//     }
//     return pairs;
// }


// int[] arr = CreateArrayRndInt(7, 0, 50);
// PrintArray(arr);
// int[] pairsArr = PairOfNumbers(arr);
// PrintArray(pairsArr);

//====================================================================================================================================

















//=====================================================================LectureVison====================================================


int[] CreatArray(int arraySize, int arrayMinValue, int arrayMaxValue)//Метод генерации массива со случайными элементами
{
    int[] resArray = new int[arraySize];
    Random rnd = new Random();
    for (int i = 0; i < resArray.Length; i++)
    {
        resArray[i] = rnd.Next(arrayMinValue, arrayMaxValue + 1);
    }
    return resArray;
}


string ArrayToString(int[] array)//Метод преобразования массива в строку
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + $" {array[i]}";
        result = i < (array.Length - 1) ? result = result + "," : result;//для корректности вывода запятых
    }
    return result + " ]";
}





int[] MakeArray(int[] array)
{
    int size = array.Length % 2 != 0 ? array.Length / 2 + 1 : array.Length / 2;
    int[] resArray = new int[size];
    for (int i = 0; i < resArray.Length; i++)
    {
        if (i == resArray.Length - 1 && array.Length % 2 == 1)    // Если тут убрать -1 (if (i == resArray.Length - 1 && array.Length % 2 == 1) ), то он будет умножать среднее число на среднее число.
        {
            resArray[i] = array[i];
        }
        else
        {
            resArray[i] = array[i] * array[array.Length - i - 1];
        }

    }
    return resArray;
}


int arraySize = 5, arrayMinValue = 0, arrayMaxValue = 10;

int[] newArray = CreatArray(arraySize, arrayMinValue, arrayMaxValue); //генерируем массив с указаными параметры
string strArray = ArrayToString(newArray);// переводим строку в массив для дальнейшего вывода на экран

int[] halfAndDouble = MakeArray(newArray);
string strHalfAndDouble2 = ArrayToString(halfAndDouble);

Console.WriteLine($"{strArray} -> {strHalfAndDouble2}");










//=====================================================================LectureVison2_ADVANCED====================================================






int[] CreatArray(int arraySize, int arrayMinValue, int arrayMaxValue)//Метод генерации массива со случайными элементами
{
    int[] resArray = new int[arraySize];
    Random rnd = new Random();
    for (int i = 0; i < resArray.Length; i++)
    {
        resArray[i] = rnd.Next(arrayMinValue, arrayMaxValue + 1);
    }
    return resArray;
}


string ArrayToString(int[] array)//Метод преобразования массива в строку
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + $" {array[i]}";
        result = i < (array.Length - 1) ? result = result + "," : result;//для корректности вывода запятых
    }
    return result + " ]";
}

int[] MakeArray(int[] array) // Метод для создания массива на основе переданного. Согласно Т.З.
{
    int size = array.Length % 2 != 0 ? array.Length / 2 + 1 : array.Length / 2; //определяем размер нового массива. Нюнасы с четным и не четным кол-вом элементов
    int[] resArray = new int[size];

    for (int i = 0; i < resArray.Length; i++)
    {
        resArray[i] = array[i] * array[array.Length - i - 1];
    }

    if (array.Length % 2 == 1) resArray[size - 1] = array[array.Length / 2];
    return resArray;
}


int arraySize = 6, arrayMinValue = 0, arrayMaxValue = 10;

int[] newArray = CreatArray(arraySize, arrayMinValue, arrayMaxValue); //генерируем массив с указаными параметры
string strArray = ArrayToString(newArray);// переводим строку в массив для дальнейшего вывода на экран

int[] halfAndDouble = MakeArray(newArray); //Создаем новый массив на основании ранее сгенернируемого
string strHalfAndDouble = ArrayToString(halfAndDouble);

Console.WriteLine($"{strArray} -> {strHalfAndDouble}");



























//=================================================EXAMPLES_FROM_LECTURER=============================================================


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}


void PrintArrayDouble(double[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i]);
    }

    Console.WriteLine("]");
}