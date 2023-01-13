// Задача 26: Напишите программу, которая 
// 1. принимает на вход число 
// 2. и выдаёт количество цифр в числе.
//
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

// Console.Write("Enter a number: ");
// int number = int.Parse(Console.ReadLine());

// int numberOfDigits = NumberOfDigits(number);

// Console.WriteLine($"{number} -> {numberOfDigits}");

// int NumberOfDigits(int num)
// {
//     int quantity = 0;
//     while (num != 0)
//     {
//         num = num / 10;
//         quantity = quantity + 1;
//     }
//     return quantity;
// }



int InsertDigit(string text) //Метод пользовательского ввода
{
    Console.Write(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int CountDigit(int insertNum)
{
    insertNum = Math.Abs(insertNum);
    int temp = 0;
    while (insertNum > 0)
    {
        insertNum = insertNum / 10;
        temp++;
    }
    return temp;
}

int userNumber = InsertDigit("Insert a number: ");
int count = CountDigit(userNumber);

Console.WriteLine($"Number of digits in {userNumber} = {count}");