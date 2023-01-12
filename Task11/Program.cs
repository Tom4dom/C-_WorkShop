// 11. Напишите программу, которая 
//1. выводит случайное трёхзначное число 
//2. и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// int number = new Random().Next(100, 1000);

// int firstDigit = number / 100;
// int secondDigit = number % 100 / 10;
// int thirdDigit = number % 100 % 10;

// int doubleFigure = firstDigit * 10 + thirdDigit;

// Console.WriteLine($"{number} -> {doubleFigure}");



// int number = new Random().Next(100, 1000);

// int ThreeToTwo = ThreeFigureToTwo(number);

// Console.WriteLine($"{number} -> {ThreeToTwo}");


// int ThreeFigureToTwo(int arg0)
// {
//     int firstDigit = arg0 / 100;
//     int secondDigit = arg0 % 100 / 10;
//     int thirdDigit = arg0 % 100 % 10;
//     int doubleFigure = firstDigit * 10 + thirdDigit;
//     return doubleFigure;
// }



// int number = new Random().Next(100, 1000);

// int firstDigit = number / 100;
// int secondDigit = number / 10 % 10;
// int thirdDigit = number % 10;

// int doubleFigure = firstDigit * 10 + thirdDigit;

// Console.WriteLine($"{number} -> {doubleFigure}");
// Console.WriteLine();
// Console.WriteLine(firstDigit);
// Console.WriteLine(secondDigit);
// Console.WriteLine(thirdDigit);


int rnd = new Random().Next(100, 1000);

int newDigit = MakeDigit(rnd);
Console.WriteLine($"{rnd} -> {newDigit}");


int MakeDigit(int number)
{
    int result = (number/100)*10 + number % 10;
    return result;
}