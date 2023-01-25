// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



int InsertDigit(string text)
{
    Console.Write(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] FibonacciWithoutRecursion(int num)
{
    int[] array = new int[num];
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i-1] + array[i-2];   
    }
    return array;
}

void ArrayPrinter(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + " ");
        else Console.Write(array[i]);
    }

    Console.Write("]");
}

int userNumber = InsertDigit("Insert a number: ");
int[] fibonumbers = FibonacciWithoutRecursion(userNumber);
ArrayPrinter(fibonumbers);






///==========================================================================================

// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int number = NumberInput("Please, input your number: ");
int[]arr = FibArray(number);
PrintArray(arr);

int NumberInput(string text) // Method fot Number input
{
Console.Write(text);
int numberinput = Convert.ToInt32(Console.ReadLine());
return numberinput;
}

int[]FibArray(int count)
{
int[] result = new int[count];
result[1] = 1;
for (int i = 2; i < count; i++)
{
result[i] = result[i-1]+result[i-2];
}
return result;
}

// Печать массива int
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

//================================================================================================================

