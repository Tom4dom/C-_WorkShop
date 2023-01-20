// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void ArrayFiller(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]} ");
    }
    Console.WriteLine();

    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = i;
        Console.Write($"{collection[i]} ");
    }
    Console.WriteLine();

    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]} ");
    }
}


int[] collection = new int[10];

ArrayFiller(collection);
PrintArray(collection);











// void FillArray(int[] collection)
// {
//     for (int i = 0; i < collection.Length; i++)
//     {
//         collection[i] = new Random().Next(0, 2);
//     }
// }

// void PrintArray(int[] collection)
// {
//     for (int i = 0; i < collection.Length; i++)
//     {
//         Console.Write($"{collection[i]} ");
//     }
// }

// int[] array = new int[10]; // 0, 1, 2, 3, 4, 5, 6, 7
// FillArray(array);
// PrintArray(array);



//==============================================================================

void ArrayFiller(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]} ");
    }
}


int[] arrayname = new int[10];
for (int i = 0; i < arrayname.Length; i++)
{
    Console.Write($"{arrayname[i]} ");
}
Console.WriteLine();

for (int i = 0; i < arrayname.Length; i++)
{
    arrayname[i] = i;
    Console.Write($"{arrayname[i]} ");
}
Console.WriteLine();

ArrayFiller(arrayname);
PrintArray(arrayname);








//==============================================================================


// int[] CreateArray(int size)
// {
//     int[] nameOfArray = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < nameOfArray.Length; i++)
//     {
//         nameOfArray[i] = rnd.Next(0, 2);
//     }
//     return nameOfArray;
// }



// void PrintArray(int[] arrayAsParameter)
// {
//     for (int i = 0; i < arrayAsParameter.Length; i++)
//     {
//         Console.Write($"{arrayAsParameter[i]} ");
//     }
// }


// int[] arr = CreateArray(16);
// PrintArray(arr);


///============================================================================================


// int[] CreationAndFillingArray(int amountOfElements)
// {
//     int[] nameOfArray = new int[amountOfElements];
//     Random randomNumberForMyArray = new Random();

//     for (int i = 0; i < nameOfArray.Length; i++)
//     {
//         nameOfArray[i] = randomNumberForMyArray.Next(0, 2);
//     }

//     return nameOfArray;
// }

// void PrintArray(int[] arrayNameAsParameter)
// {
//     for (int i = 0; i < arrayNameAsParameter.Length; i++)
//     {
//         Console.Write($"{arrayNameAsParameter[i]} ");
//     }

// }


// int[] array = CreationAndFillingArray(5);
// PrintArray(array);
