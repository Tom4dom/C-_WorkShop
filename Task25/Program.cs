// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int NumberFromUsr(string txt)
{
    Console.Write(txt);
    int numberFromUsr = Convert.ToInt32(Console.ReadLine());
    return numberFromUsr;
}

void PowerOfNumber(int parameterA, int parameterB)
{
    parameterB = Math.Abs(parameterB);
    int powerOfNumber = parameterA;
    for (int i = 1; i < parameterB; i++)
    {
        powerOfNumber = powerOfNumber * parameterA;
    }
    Console.WriteLine($"{parameterA}, {parameterB} -> {powerOfNumber}");
}

int numA = NumberFromUsr("Enter your number A: ");
int numB = NumberFromUsr("Enter your number B: ");
PowerOfNumber(numA, numB);
