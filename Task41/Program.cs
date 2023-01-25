
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

int[] UserInputMethod()
{
    Console.Write("Enter intergers separated by space (for example: 5 3 9 -3 4 5): ");
    string line = Console.ReadLine();
    string[] splittedStringArray = line.Split(' ');
    int[] arr = new int[splittedStringArray.Length];


    for (int i = 0; i < splittedStringArray.Length; i++)
    {
        int temp = int.Parse(splittedStringArray[i]);
        arr[i] = temp;
    }
    return arr;
}

void ArrayPrinter(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + "; ");
        else Console.Write(array[i]);
    }

    Console.Write("]");
}

int Counter(int[] collection)
{
    int counter = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > 0)
        {
            counter = counter + 1;
        }
    }
    return counter;
}

int[] numbers = UserInputMethod();
ArrayPrinter(numbers);
int count = Counter(numbers);
Console.WriteLine($" -> {count} number/numbers greater than 0");