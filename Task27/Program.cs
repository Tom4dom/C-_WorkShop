// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InsertDigit(string text)
{
    Console.Write(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumOfDigitsInNumber(int insertNum)
{

    int temp = 0;
    while (insertNum != 0)
    {
        int rem = insertNum % 10;
        insertNum = insertNum / 10;
        temp = temp + rem;
    }
    return temp;
}

int userNumber = InsertDigit("Insert a number: ");
int count = SumOfDigitsInNumber(userNumber);

Console.WriteLine($"{userNumber} -> {count}");





// int NumberFromUsr(string txt)
// {
//     Console.Write(txt);
//     int numberFromUsr = Convert.ToInt32(Console.ReadLine());
//     return numberFromUsr;
// }

// void SumOfDigitsInNumber(int usrnum)
// {
//     int sumOfDigitsInNumber = 0;
//     int index = usrnum;
//     while (index != 0)
//     {
//         int temp = usrnum;
//         int remainderOfDivision = temp % 10;
//         sumOfDigitsInNumber = sumOfDigitsInNumber + remainderOfDivision;
//         index = index / 10;
//     }
//     Console.WriteLine(sumOfDigitsInNumber);
// }

// int numA = NumberFromUsr("Enter your number: ");
// SumOfDigitsInNumber(numA);



// int InsertDigit(string text)
// {
//     Console.Write(text);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int CountDigit(int insertNum) //Counter of digits in a number
// {
//     //insertNum = Math.Abs(insertNum);
//     int temp = 0;
//     while (insertNum != 0)  /////////////// Get to the bottom of why != is better than > and in this case! // I KNOW IT NOW)))
//     {
//         insertNum = insertNum / 10;
//         temp++;
//     }
//     return temp;
// }

// int userNumber = InsertDigit("Insert a number: ");
// int count = CountDigit(userNumber);

// Console.WriteLine($"Number of digits in {userNumber} = {count}");