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


// // double a = 4.52;

// // int b = (int)a;

// // double c = b;

// // short variableOne = 4255;
// // byte variableTwo = (byte)variableOne;



// // Console.WriteLine(variableTwo);


// short x = 150;
// byte y = (byte)(x + x);

// // Console.WriteLine(y);


// using System;

// public class MainClass
// {
//     public static void Main()
//     {
//         string text = Console.ReadLine();

//         string newLine = "Вы ввели: " +  text;

//         Console.WriteLine(newLine); 

//     }
// }



// public class MainClass
// {
//     public static void Main()
//     {
//         Console.WriteLine("Введите два целых числа через пробел"); 
//         string line = Console.ReadLine();
//         string[] splitString = line.Split(' ');

//         int x1 = int.Parse(splitString[0]);
//         int x2 = int.Parse(splitString[1]);

//         int sum = x1 + x2; // Запишите тут Ваш код для вычисления суммы значений x1 и x2
//         int difference = x1 - x2; // Запишите тут Ваш код для вычисления разности значений x1 и x2
//         int multiply =  x1 * x2; // Запишите тут Ваш код для вычисления произведения значений x1 и x2
//         Console.WriteLine($"{sum} {difference} {multiply}"); 
//     }



//     using System;

// public class MainClass
// {
//     public static void Main()
//     {        
//         Console.WriteLine("Input distance in meters: ");
//         int n = Convert.ToInt32(Console.ReadLine()); // преобразуем введенную строку в число 
//                                                      // и присваиваем его значение переменной

//         int distance = n / n; //Запишите тут Ваш код для вычислений

//         Console.WriteLine(distance); 
//     }
// }




// int UsrInputNums(string usrtxt)
// {
//     Console.Write(usrtxt);
//     string line = Console.ReadLine();
//     string[] splitString = line.Split(' ');
//     int num = int.Parse(splitString[0]);
//     return num;
// }


// int numA = UsrInputNums("Enter two integers A: ");
// int numB = UsrInputNums("Enter two integers B: ");
// Console.WriteLine(numA);
// Console.WriteLine(numB);












//=======================================================================================================================


// Наталья Кузовлева, [23.01.2023 20:38]
// Задача 46. Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Наталья Кузовлева, [23.01.2023 20:39]
// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns]; // 0, 1
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++) // 2
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // 
//         {
//             matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3   100, 1000   
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5},");
//             else Console.Write($"{matrix[i, j], 5}  ");
//         }
//         Console.WriteLine("]");
//     }
// }

// int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
// PrintMatrix(array2D);

// Наталья Кузовлева, [23.01.2023 20:41]
// // Задача 48: Задайте двумерный массив размера m на n,
// // каждый элемент в массиве находится по формуле: Amn = m+n.
// // Выведите полученный массив на экран.
// // m = 3, n = 4.
// // 0 1 2 3
// // 1 2 3 4
// // 2 3 4 5

// int[,] arr1 = CreatMatrixNM(3, 4, 1, 50);
// PrintMatrix(arr1);


// // Создание рандомного двумерного массива int
// int[,] CreatMatrixNM(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i + j;
//         }
//     }
//     return matrix;
// }

// // Печать массива int
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write(matrix[i, j] + ",");
//             else Console.Write(matrix[i, j]);
//         }
//         Console.WriteLine("]");
//     }
// }

// Наталья Кузовлева, [23.01.2023 20:41]
// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Наталья Кузовлева, [23.01.2023 20:42]
// void SquareMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i+=2)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j+=2)
//         {
//             matrix[i,j]*=matrix[i,j];
//         }
//     }
// }

// int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
// PrintMatrix(array2D);
// SquareMatrix(array2D);
// Console.WriteLine();
// PrintMatrix(array2D);

// Наталья Кузовлева, [23.01.2023 20:43]
// // Задача 51: Задайте двумерный массив. Найдите сумму
// // элементов, находящихся на главной диагонали (с индексами
// // (0,0); (1;1) и т.д.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Сумма элементов главной диагонали: 1+9+2 = 12

// Наталья Кузовлева, [23.01.2023 20:44]
// // Суммирование элементов на диагонали Вариант 1
// int MatrixTrace(int[,] matrix)
// {
//     int sum = 0;
//     int k = 0;
//     if (matrix.GetLength(0) < matrix.GetLength(1)) k = matrix.GetLength(0);
//     else k = matrix.GetLength(1);
//     for (int i = 0; i < k; i++)
//     {
//         sum += matrix[i, i];
//     }
//     return sum;
// }

// Наталья Кузовлева, [23.01.2023 20:44]
// // Вариант 2
// int SummMatrix(int[,] matrix)
// {
//     int summMatr = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j) summMatr += matrix[i, j];
//         }
//     }
//     return summMatr;
// }

// int[,] arr1 = CreatMatrixNM(5, 4, 1, 10);
// int summ = SummMatrix(arr1);
// PrintMatrix(arr1);
// System.Console.WriteLine($"Сумма элементов главной диагонали: {summ}");

//=======================================================================================================================




// string[,] table = new string[2, 5];

// table[0,1] = "word01";
// table[1,2] = "word12";
// table[1,3] = "word13";
// table[0,2] = "word02";

// table[1,4] = "word14";
// table[1,1] = "word11";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5 ; columns++)
//     {
//         Console.WriteLine($"=={table[rows, columns]}== ");
//     }
// }


//=========================================================================================


// void PrintMultiDemensionalArray(int[,] mat)
// {
//     for (int rows = 0; rows < mat.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < mat.GetLength(1); columns++)
//         {
//             Console.Write($"--{mat[rows, columns]}--");
//         }
//         Console.WriteLine();
//     }
// }

// void FillMultiDemensionalArray(int[,] arr)
// {
//     Random rnd = new Random();
//     for (int rows = 0; rows < arr.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < arr.GetLength(1); columns++)
//         {
//             arr[rows, columns] = rnd.Next(1, 10);
//         }
//     }
// }

// int[,] matrix = new int[4, 6];

// PrintMultiDemensionalArray(matrix);
// Console.WriteLine();
// FillMultiDemensionalArray(matrix);
// PrintMultiDemensionalArray(matrix);


//=======================================================================================


// int[,] picture = new int[,]
// {
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };


// void PrintMultiDemensionalArrayAsImage(int[,] pic)
// {
//     for (int rows = 0; rows < pic.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < pic.GetLength(1); columns++)
//         {
//             if (pic[rows, columns] == 0)
//             {
//                 Console.Write(" ");
//             }
//             else
//             {
//                 Console.Write($"*");
//             }
//         }
//         Console.WriteLine();
//     }
// }


// void PictureFiller(int row, int column)
// {
//     if (picture[row, column] == 0)
//     {
//         picture[row, column] = 1;
//         PictureFiller(row - 1, column);
//         PictureFiller(row, column - 1);
//         PictureFiller(row + 1, column);
//         PictureFiller(row, column + 1);
//     }
// }




// PrintMultiDemensionalArrayAsImage(picture);
// PictureFiller(3,9);
// PrintMultiDemensionalArrayAsImage(picture);






// int Factorial(int n)
// {
//     //0! = 1
//     //1! = 1
//     //2! = 2
//     //3! = 6
//     //4! = 24
//     //5! = 120
//     //6! = 720
//     if (n == 0) return 1;
//     else return n * Factorial(n - 1);
// }


// for (int i = 0; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }







int Fiba(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fiba(n-1) + Fiba(n-2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fiba(i));
}

