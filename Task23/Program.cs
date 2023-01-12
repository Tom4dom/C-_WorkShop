// Задача 23:
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



void Numb(int n1)
{
int counter = 1;
while(counter <= n1)
{
Console.WriteLine($"{counter, 3} {counter * counter * counter, 3}");
counter++;
}
}


System.Console.WriteLine("Enter a natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

while(number < 1)
{
System.Console.WriteLine("Only positive integer can be accepted!");
number = Convert.ToInt32(Console.ReadLine());
}

Numb(number);