// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Input a number:  ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (IfoutOfRange(numberA))
{
    Console.WriteLine($"{numberA} - > there is no third digit");
}
else
{
    while (CycleRange(numberA))
    {
        numberA = numberA / 10;
    }
    int ThirdDigit = numberA % 10;
    Console.WriteLine($"{numberA} -> {ThirdDigit}");
}


bool IfoutOfRange(int arg0)
{
    return (arg0 < 100 && arg0 > -100);
}


bool CycleRange(int arg0)
{
    return arg0 > 999 || arg0 < -999;
}











// Console.Write("Input a number:  ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// ThirdDigit(numberA);

// void ThirdDigit(int num)
// {
//     int counter = 0;
//     int result = num / 10;
//     while (counter <= result)
//     {
//         if (Method(numberA)) //if (result < 10) 
//         {
//             Console.WriteLine("there is no third digit");
//             break;
//         }
//         else if (10 * counter <= result & result < 100 * counter)
//         {
//             Console.WriteLine($"third digit - {num / counter % 10}");
//         }
//         counter *= 10;
//     }
// }



// bool Method(int arg0)
// {
//     return arg0 < 100;
// }












// if (usrNmbr <= 999)
// {
//     int secondDigit = Method(usrNmbr);
//     Console.WriteLine($"{usrNmbr} -> {secondDigit}");
// }
// else
// {
//     Console.WriteLine("Incorrect number!");
// }








// int Method(int arg0)
// {
//     int result = (arg0 % 100) / 10;
//     return result;
// }




// Console.WriteLine("Input a number: ");
// int usrNmbr = Convert.ToInt32(Console.ReadLine());

// if (usrNmbr < 100)
// {
//     Console.WriteLine($"{usrNmbr} -> there is no third digit");
// }
// else
// {
//     while (usrNmbr > 999)
//     {
//         usrNmbr / 10;
//     } 
//     int thirdDigit = usrNmbr % 10;
// }

// Console.WriteLine($"{thirdDigit}");











// while (n>0) {n=n/10; index++}




























// while (true)
// {
//     if (Method0(numberA))
//     {
//         Console.WriteLine("there is no third digit");
//     }
//     else if (Method1(numberA))
//     {
//         numberA = numberA / 10;

//     }
//     int ThirdDigit = numberA % 10;
//     Console.WriteLine($"{ThirdDigit}");

// }



// bool Method0(int arg0)
// {
//     return arg0 < 100;
// }

// bool Method1(int arg0)
// {
//     return arg0 > 999;
// }