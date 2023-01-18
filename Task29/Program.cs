// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] CreateArray(int size)
{
    int[] nameOfArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < nameOfArray.Length; i++)
    {
        nameOfArray[i] = rnd.Next(0, 100);
    }
    return nameOfArray;
}



void PrintArray(int[] arrayAsParameter)
{
    for (int i = 0; i < arrayAsParameter.Length; i++)
    {
        Console.Write($"{arrayAsParameter[i]} ");
    }
}


int[] arr = CreateArray(16);
PrintArray(arr);

