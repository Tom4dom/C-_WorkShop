// Задача 40: 
// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.

// Подсказка:
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.





int UsrInputNums(string usrtxt)
{
    Console.Write(usrtxt);
    string line = Console.ReadLine();
    string[] splitString = line.Split(' ');
    int num = int.Parse(splitString[0]);
    return num;
}


void MightOrMightNotExist(int a, int b, int c)
{
    if (a < b+c && b < a+c && c < a+b)
    {
        Console.WriteLine ("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

bool MightOrMightNotExistBOOOOOOOL(int a, int b, int c)
{
  return (a < b+c && b < a+c && c < a+b);
}



int numA = UsrInputNums("Enter integer A: ");
int numB = UsrInputNums("Enter integer B: ");
int numC = UsrInputNums("Enter integer C: ");
Console.WriteLine(numA);
Console.WriteLine(numB);
Console.WriteLine(numC);

MightOrMightNotExist(numA, numB, numC);

Console.WriteLine(MightOrMightNotExistBOOOOOOOL(numA, numB, numC) ? $"A triangle with sides {numA}, {numB}, {numC} can exist" : "Can't");





// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

// System.Console.WriteLine("Выведите 3 числа: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) Console.WriteLine("Да");
// else System.Console.WriteLine("Нет");

// 









// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


// int side1 = NumberInput("Please, input your number 1");
// int side2 = NumberInput("Please, input your number 2");
// int side3 = NumberInput("Please, input your number 3");
// Console.WriteLine(ExistTriangle(side1, side2, side3) ? "Triangle Exist" : "Triangle Does not exist");

// int NumberInput(string text) // Method fot Number input
// {
// Console.WriteLine(text);
// int numberinput = Convert.ToInt32(Console.ReadLine());
// return numberinput;
// }

// bool ExistTriangle(int s1, int s2, int s3)
// {
// return s1 < s2 + s3 && s2 < s1 + s3 && s3 < s2 + s1;
// }



