// Задача 31: 
// 1. Задайте массив из 12 элементов
// 2. заполненный случайными числами из промежутка [-9, 9].
// 3. Найдите сумму отрицательных и положительных элементов массива.
//
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, 
// сумма отрицательных равна -20.

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
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if(i < array.Length - 1) Console.Write (array[i] + ",");
else Console.Write (array[i]);
}
Console.WriteLine("]");
}

int GetSumPositiveElem(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
if(array[i] > 0) sum += array[i];
}
return sum;
}

int GetSumNegativeElem(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
if(array[i] < 0) sum += array[i];
}
return sum;
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);

int sumPositive = GetSumPositiveElem(arr);
int sumNegative = GetSumNegativeElem(arr);

Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");






















//=========================================================== My Vision ========================================


// int[] ArrayCreator(string txt)
// {
//     Console.Write(txt);
//     int num = Convert.ToInt32(Console.ReadLine());
//     int[] nameOfArray = new int[num];
//     Random rnd = new Random();
//     for (int i = 0; i < nameOfArray.Length; i++)
//     {
//         nameOfArray[i] = rnd.Next(-9, 10);
//     }
//     return nameOfArray;
// }

// void ArrayPrinter(int[] collection)
// {
//     Console.Write("Elements of the array look like this:");
//     Console.Write(" [ ");
//     for (int i = 0; i < collection.Length; i++)
//     {
//         Console.Write($"{collection[i]}, ");
//     }
//     Console.Write("]");
// }

// int[] SumOfArrayElements(int[] collection)
// {
//     int[] posNeg = new int[2];
//     for (int i = 0; i < collection.Length; i++)
//     {
//         if (collection[i] > 0)
//         {
//             posNeg[0] = posNeg[0] + collection[i];
//         }
//         else
//         {
//             posNeg[1] = posNeg[1] + collection[i];
//         }
//     }
//     return posNeg;


// }


// int[] array = ArrayCreator("Enter array length: ");
// Console.WriteLine();
// ArrayPrinter(array);
// Console.WriteLine();
// int[] posNegSum = SumOfArrayElements(array);
// Console.WriteLine();
// Console.WriteLine($"Sum of POSITIVE elements of your array equals:  {posNegSum[0]}");
// Console.WriteLine();
// Console.WriteLine($"Sum of NEGATIVE elements of your array equals: {posNegSum[1]}");
// Console.Write(typeof(string).Assembly.ImageRuntimeVersion);






//=======================================================================================================================









// int UsrInputNums(string usrtxt)
// {
//     Console.Write(usrtxt);
//     string line = Console.ReadLine();
//     string[] splitString = line.Split(' ');
//     int num = int.Parse(splitString[0]);
//     return num;
// }


// int numA = UsrInputNums("Enter two integers A: ");
// int numB = UsrInputNums("Enter two integers B: ");
// Console.WriteLine(numA);
// Console.WriteLine(numB);











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

















// void ArrayFiller(int[] collection)
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


// int[] arrayname = new int[10];

// ArrayFiller(arrayname);
// PrintArray(arrayname);


