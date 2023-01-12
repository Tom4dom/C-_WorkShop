// 12. Напишите программу, которая будет
// 1. принимать на вход два числа 
// 2. и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


bool DivCheck(int arg0, int arg1)
{
    return arg0 % arg1 == 0;
}


Console.WriteLine("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(DivCheck(number1, number2))
{
    Console.WriteLine($"{number1} divisible to {number2}");
}
else
{
    Console.WriteLine($"{number1} is not divisible to {number2} the remainder is {number1 % number2}");
}


// int divisibleOrNot = DivisibleOrNot(number1, number2);


// if (number1 % number2 == 0) Console.WriteLine ($"{number1} divisible to {number2}");
// else Console.WriteLine($"{number1} not divisible to {number2}, the remainder is {number1 % number2}");

// Console.WriteLine("Enter the first number: ");
// int userNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the second number: ");
// int userNumber2 = Convert.ToInt32(Console.ReadLine());

// bool DivCheck(int number1, int number2)
// {
//     return number1 % number2 == 0;
// }

// if (DivCheck(userNumber, userNumber2))
// {
//     Console.WriteLine($"{userNumber} divisible to {userNumber2}");
// }
// else
// {
//     Console.WriteLine($"{userNumber} is not divisible to {userNumber2} the remainder is " + (userNumber % userNumber2));
//     Console.WriteLine($"{userNumber} is not divisible to {userNumber2} the remainder is {userNumber % userNumber2}");
// }

















// int DivisibleOrNot(int arg0, int arg1);
// {
//     if (arg0 % arg1 == 0)
//     return Console.WriteLine($"{arg0} divisible to {arg1}");
// }




// 
//     }
// // else
// //     {
// //         return Console.WriteLine($"{arg0} not divisible to {arg1}, the remainder is {arg0 % arg1}");
// //     }
// }