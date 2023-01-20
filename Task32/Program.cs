// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]



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
if(i < arr.Length - 1) Console.Write (arr[i] + ",");
else Console.Write (arr[i]);
}
Console.WriteLine("]");
}

void ArrayElementConverter(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > 0)
        {
            collection[i] = collection[i] - collection[i] * 2;
        }
        else
        {
            collection[i] = collection[i] - collection[i] - collection[i];
        }
    }
}

int[] array = ArrayCreator(12, -9, 9);
ArrayPrinter(array);
ArrayElementConverter(array);
ArrayPrinter(array);



