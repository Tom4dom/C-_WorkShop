// Задача 57: 
// 1. Составить частотный словарь элементов двумерного массива. 
// 1.1 Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


// Набор данных                       Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }       0 встречается 2 раза
//                                  1 встречается 1 раз
//                                  2 встречается 1 раз
//                                  8 встречается 1 раз
//                                  9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
//                                 1 встречается 3 раза
//                                 2 встречается 2 раз
//                                 3 встречается 1 раз
//                                 4 встречается 1 раз
//                                 6 встречается 2 раза



int[,] TwoDementionalArrayCreator(int sizeRows, int sizeColumns, int min, int max)
{
    int[,] matrix = new int[sizeRows, sizeColumns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void ArrayPrinter(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}


void OneDemArrayPrinter(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write($"{arr[i]} ");
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[index] = matrix[i, j];
            index++;
        }
    }
    OneDemArrayPrinter(array);
    Console.WriteLine();
    Array.Sort(array);
    return array;
}



int rows = 4;
int columns = 4;
int min = 0;
int max = 9;
int[,] myTwoDemArray = TwoDementionalArrayCreator(rows, columns, min, max);
ArrayPrinter(myTwoDemArray);
int[] result = MatrixToArray(myTwoDemArray);
Console.WriteLine();
OneDemArrayPrinter(result);








//=========================================================================================


// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


int[,] CreatMatrixRndIntArray(int rowSize, int colSize, int minValue, int maxValue)//Метод генерации массива со случайными элементами
{
    int[,] resArray = new int[rowSize, colSize];
    Random rnd = new Random();

    for (int i = 0; i < resArray.GetLength(0); i++)
        for (int j = 0; j < resArray.GetLength(1); j++)
            resArray[i, j] = rnd.Next(minValue, maxValue + 1);

    return resArray;
}


string ArrayToString(int[,] array)//Метод преобразования массива в строку
{
    string result = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result += "[";

        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + $" {array[i, j],3}";
            result = j < (array.GetLength(1) - 1) ? result + "," : result;//для корректности вывода запятых    
        }

        result += "]\n";
    }
    return result;
}

string ArrayToString2(int[,] array)//Метод преобразования массива в строку
{
    string result = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i, 1] == 0) break;//Если количество элементов равно нулю мы дошли до низу массива
        result += "[";

        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + $" {array[i, j],3}";
            result = j < (array.GetLength(1) - 1) ? result + "," : result;//для корректности вывода запятых    
        }

        result += "]\n";
    }
    return result;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.WriteLine(array[i] + "]");
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

int[,] CreateDictionaryFromArray(int[] array)
{
    int[,] matrixArray = new int[array.Length, 2];
    int currValue = array[0];
    matrixArray[0, 0] = currValue;
    matrixArray[0, 1] = 1;
    int cnt = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currValue)
        {
            matrixArray[cnt, 1]++;
        }
        else
        {
            cnt++;
            matrixArray[cnt, 0] = array[i];
            matrixArray[cnt, 1]++;
            currValue = array[i];
        }
    }
    return matrixArray;
}



//Параметры для генерации двумерного массива типа int.
int matrixRowSize = 3,
    matrixColSize = 3,
    matrixMinValue = -10,
    matrixMaxValue = 10;

int[,] rndMatrixInt = CreatMatrixRndIntArray(matrixRowSize, matrixColSize, matrixMinValue, matrixMaxValue);

Console.WriteLine(ArrayToString(rndMatrixInt));

int[] tmpArray = MatrixToArray(rndMatrixInt);
Array.Sort(tmpArray);

PrintArray(tmpArray);

int[,] dictionaryMatrix = CreateDictionaryFromArray(tmpArray);

Console.WriteLine(ArrayToString2(dictionaryMatrix));








//=================================================================================================


void CountDictionary(int[] arr)
{
    int count = 1;
    int num = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num)
            count++;
        else
        {
            Console.WriteLine($"Quantity of numbers {num} = {count} ");
            count = 1;
			num = arr[i];
		}
	}
	Console.WriteLine($"Quantity of numbers {num} = {count} ");
}


