// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// Console.Write("Введите количество строк массива:");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива:");
// int n1 =  Convert.ToInt32(Console.ReadLine());

// double [,] GetArray = new double[m1, n1];
// Random rnd = new Random();
// void FillArray(double[,] res)
// {
//     for (int i = 0; i < m1; i++)
//     {
//         for (int j = 0; j < n1; j++)
//         {
//             res [i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);
//         }
//     }
    

// }

// void PrintArray(double [,] inArray)
// {
//     for(int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// FillArray(GetArray );
// Console.WriteLine();
// PrintArray(GetArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


// Console.Write("Введите количество строк массива:");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива:");
// int d1 =  Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[b1, d1];

// void GetArray2D(int[,] numbers)
// {
//      for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         for (int j = 0; j < numbers.GetLength(1); j++)
//         {
//             numbers[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
//  void PrintArray(int[,] numbers)
// {
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         for (int j = 0; j < numbers.GetLength(1); j++)
//         {
//             Console.Write(numbers [i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// GetArray2D(numbers);
// PrintArray(numbers);

//  Console.WriteLine("Введите координаты");
//  int a = Convert.ToInt32(Console.ReadLine());
//  int b = Convert.ToInt32(Console.ReadLine());

//  if (a>b1 && b>d1)
//  {
//      Console.WriteLine("такого числа нет");
//  }

//  else
//  {
//     Console.Write($"строка{a}; столбец{b}");
    
//  }
 
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int a = new Random().Next(1, 10);
// int b = new Random().Next(1, 10);
// int[,] arr = new int [a,b];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j ++)
//     {
//         arr[i, j] = new Random().Next(1, 10);
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine(arr.GetLength(0));
// double sum = 0;
// for (int j = 0; j < arr.GetLength(1); j++)
// {;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//          sum += arr[i, j];
//     }
//     Console.Write($"{sum / arr.GetLength(0)} ");
// }