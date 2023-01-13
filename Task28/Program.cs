// Задача 28: Напишите программу, которая
//
// 1. принимает на вход число N 
// 2. и выдаёт произведение чисел от 1 до N.
//
// 4 -> 24
// 5 -> 120



// int InsertDigit(string text) //Метод пользовательского ввода
// {
//     Console.Write(text);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int Factorial(int num)
// {
//     int productOfNumbers = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         productOfNumbers = productOfNumbers * i;
//     }
//     return productOfNumbers;
// }


// int userNumber = InsertDigit("Insert a number: ");
// int factorial = Factorial(userNumber);
// Console.WriteLine($"{userNumber} -> {factorial}");





// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int Multiply(long num)
{
int result = 1;
for (int i = 1; i <= num; i++)
{
result = result * i;
}
return result;
}


int InsertDigit(string text) //Метод пользовательского ввода
{
Console.Write(text);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

int num = InsertDigit("Enter a number: ");
int mult = Multiply(num);
System.Console.WriteLine($"{num} -> {mult}");