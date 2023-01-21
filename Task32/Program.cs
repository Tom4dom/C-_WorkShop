// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

//========================================================MyVision===============================================

int[] ArrayCreator(int size, int min, int max)
{
    int[] nameOfArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < nameOfArray.Length; i++)
    {
        nameOfArray[i] = rnd.Next(min, max+1);
    }
    return nameOfArray;
}

void ArrayPrinter(int[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
if(i < arr.Length - 1) Console.Write (arr[i] + ", ");
else Console.Write (arr[i]);
}
Console.WriteLine("]");
}

void ArrayElementConverter(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        //collection[i] = -1 * collection[i];
        collection[i] = -collection[i];
        // if (collection[i] > 0)
        // {
        //     collection[i] = collection[i] - collection[i] * 2;
        // }
        // else
        // {
        //     collection[i] = collection[i] - collection[i] - collection[i];
        // }
    }
}

int[] array = ArrayCreator(12, -9, 9);
ArrayPrinter(array);
ArrayElementConverter(array);
ArrayPrinter(array);










//===============================ClassVision==================================================


// / Задача 32: Напишите программу замена элементов
// // массива: положительные элементы замените на
// // соответствующие отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

// void ChangeOverNumb(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = -array[i];
// }
// }

// int[] create = CreateArrayRndInt(4, -10, 10);

// PrintArray(create);
// ChangeOverNumb(create);
// PrintArray(create);









