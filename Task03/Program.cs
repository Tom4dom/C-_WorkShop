// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятниц


// Console.WriteLine("Please, input the number of the day of the week: ");
// int day = Convert.ToInt32(Console.ReadLine());

// // if (day == 1)
// {
//     Console.WriteLine("Monday");
// }
// if (day == 2)
// {
//     Console.WriteLine("Tuesday");
// }
// if (day == 3)
// {
//     Console.WriteLine("Wednesday");
// }
// if (day == 4)
// {
//     Console.WriteLine("Thursday");
// }
// if (day == 5)
// {
//     Console.WriteLine("Friday");
// }
// if (day == 6)
// {
//     Console.WriteLine("Saturday");
// }
// if (day == 7)
// {
//     Console.WriteLine("Sunday");
// }
// else
// {
//     Console.WriteLine("Sorry! But it is not a number of the day of the week!");
// }




Console.WriteLine("Please, input the number of the day of the week: ");
string day = Console.ReadLine();

if (day == "1")
{
    Console.WriteLine("It is Monday");
}
else if (day == "2")
{
    Console.WriteLine("It is Tuesday");
}
else if (day == "3")
{
    Console.WriteLine("It is Wednesday");
}
else if (day == "4")
{
    Console.WriteLine("It is Thursday");
}
else if(day == "5")
{
    Console.WriteLine("It is Friday");
}
else if(day == "6")
{
    Console.WriteLine("It is Saturday");
}
else if(day == "7")
{
    Console.WriteLine("It is Sunday");
}
else
{
    Console.WriteLine("Sorry! But this is not a number of the day of the week!");
}

