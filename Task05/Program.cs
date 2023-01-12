// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"



Console.Clear();
Console.WriteLine("Dear user input natural number: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = -number;

while (counter <= number)
{
    Console.Write(counter + " ");
    counter = counter + 1;
}



