// double numberA = new Random().Next(1, 10);

// double numberB = new Random().Next(1, 10);

// double numberC = new Random().Next(1, 10);

// double numberD = new Random().Next(1, 10);

// double sum = numberA + numberB / numberC * numberD;

// Console.WriteLine($"{numberA} + {numberB} / {numberC} * {numberD} = {sum}");



// double numA = new Random().Next(1, 101);
// double numB = new Random().Next(1, 101);
// double numC = new Random().Next(1, 101);
// double numD = new Random().Next(1, 101);
// double numE = new Random().Next(1, 101);
// double numF = new Random().Next(1, 101);
// double numG = new Random().Next(1, 101);

// double result = ((numA + numB) + numC * numD / (numE * numF)) + numG;

// Console.WriteLine();
// Console.WriteLine($"(({numA} + {numB}) + {numC} * {numD} / ({numE} * {numF})) + {numG} = {result}");




// int A = new Random().Next(1, 10);
// int B = new Random().Next(1, 10);
// int C = new Random().Next(1, 10);

// int sum = A + B + C;

// Console.WriteLine($"{A} + {B} + {C} = {sum}");


// Console.WriteLine("Input your name: ");
// string username = Console.ReadLine();

// if (username.ToLower() == "masha")
// {
//     Console.WriteLine("Oh, it's Masha! I'm glad to see, my dear");
// }

// else
// {
//     Console.WriteLine($"Hi, {username}");
// }





// Console.WriteLine("Input your name: ");
// string username = Console.ReadLine();

// if (username.ToLower() == "masha")
// {
//     Console.WriteLine("Oh, it's she!");
// }
// else
// {
//     Console.WriteLine($"Hi, {username}");
// }


// int a = 11;
// int b = 8;
// int c = 333;
// int d = 2;
// int e = 94;

// int max = a;
// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// if (d > max)
// {
//     max = d;
// }
// if (e > max)
// {
//     max = e;
// }

// Console.WriteLine(max); 


// Console.Clear();
// Console.SetCursorPosition(5, 4);
// Console.WriteLine("*");
// Console.SetCursorPosition(4, 4);
// Console.WriteLine("*");
// Console.SetCursorPosition(3, 4);
// Console.WriteLine("*");
// Console.SetCursorPosition(2, 4);
// Console.WriteLine("*");
// Console.SetCursorPosition(1, 4);
// Console.WriteLine("*");
// Console.SetCursorPosition(0, 4);
// Console.WriteLine("*");

// Console.Clear();

// int xa =40;
// int ya =1;

// int xb =1;
// int yb =30;

// int xc =80;
// int yc =30;

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("*");

// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("*");

// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("*");


// Console.Clear();

// int xa = 50;
// int ya = 1;

// int xb = 1;
// int yb = 30;

// int xc = 100;
// int yc = 30;

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("A");

// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("B");

// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("C");

// int x = xa, y = ya; // A

// int count = 0;

// while (count < 10000)
// {
//     int what = new Random().Next(0, 3); // [0;3] 0 1 2
//     if (what == 0)
//     {
//         if (count == 0)
//         {
//             x = (x + xa) / 2;
//             y = (y + ya) / 2;
//             Console.SetCursorPosition(x, y);
//             //Console.ReadLine();
//         }
//         else
//         {
//             x = (x + xa) / 2;
//             y = (y + ya) / 2;
//             Console.SetCursorPosition(x, y);
//             Console.WriteLine("0A");
//            // Console.ReadLine();
//         }

//     }

//     if (what == 1)
//     {
//         x = (x + xb) / 2;
//         y = (y + yb) / 2;
//         Console.SetCursorPosition(x, y);
//         Console.WriteLine("1B");
//         //Console.ReadLine();
//     }

//     if (what == 2)
//     {
//         x = (x + xc) / 2;
//         y = (y + yc) / 2;
//         Console.SetCursorPosition(x, y);
//         Console.WriteLine("2C");
//         //Console.ReadLine();
//     }
//     count = count + 1;
// }
// Console.SetCursorPosition(50, 36);