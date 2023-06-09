﻿// Домашнее задание №8
// Знакомство с языками программирования (семинары)
// Урок 8. Двумерные массивы. Продолжение

// -------------------Задачи повышенной сложности---------------------
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// -------------------------------------------------------------------

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// using System;

// namespace task54
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("введите количество строк");
//             int linesVol = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("введите количество столбцов");
//             int columnsVol = Convert.ToInt32(Console.ReadLine());
//             int[,] numbers = new int[linesVol, columnsVol];
//             FillArrayRandomNumbers(numbers);
//             Console.WriteLine();
//             Console.WriteLine("Массив до изменения");
//             PrintArray(numbers);
            
//             for (int i = 0; i < numbers.GetLength(0); i++)
//             {
//                 for (int j = 0; j < numbers.GetLength(1) - 1; j++)
//                 {
//                     for (int z = 0; z < numbers.GetLength(1) - 1; z++)
//                     {
//                         if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
//                         {
//                             int temp = 0;
//                             temp = numbers[i, z];
//                             numbers[i, z] = numbers[i, z + 1];
//                             numbers[i, z + 1] = temp;
//                         }
//                    }
//                 }
//             }
//             Console.WriteLine();
//             Console.WriteLine("Массив с упорядоченными значениями");
//             PrintArray(numbers);
            
//             void FillArrayRandomNumbers(int[,] array)
//             {
//                 for (int i = 0; i < array.GetLength(0); i++)
//                 {
//                     for (int j = 0; j < array.GetLength(1); j++)
//                     {
//                         array[i, j] = new Random().Next(0, 10);
//                     }
//                 }
//             }

//             void PrintArray(int[,] array)
//             {
//                 for (int i = 0; i < array.GetLength(0); i++)
//                 {
//                     Console.Write("[ ");
//                     for (int j = 0; j < array.GetLength(1); j++)
//                     {
//                         Console.Write(array[i, j] + " ");
//                     }
//                     Console.Write("]");
//                     Console.WriteLine("");
//                 }
//             }
//         }
//     }
// }


// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// using System;

// namespace task56
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("введите размер квадратного массива");
//             int massVol = Convert.ToInt32(Console.ReadLine());
//             int[,] numbers = new int[massVol, massVol];
//             FillArrayRandomNumbers(numbers);
//             PrintArray(numbers);
//             int minsum = Int32.MaxValue;
//             int indexLine = 0;
            
//             for (int i = 0; i < numbers.GetLength(0); i++)
//             {
//                 int sum = 0;
//                 for (int j = 0; j < numbers.GetLength(1); j++)
//                 {
//                    sum = sum + numbers[i, j];
//                 }
//                 if (sum < minsum)
//                 {
//                     minsum = sum;
//                     indexLine++;
//                 }
//             }
            
//             Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));
            
//             void FillArrayRandomNumbers(int[,] array)
//             {
//                 for (int i = 0; i < array.GetLength(0); i++)
//                 {
//                     for (int j = 0; j < array.GetLength(1); j++)
//                     {
//                         array[i, j] = new Random().Next(0, 10);
//                     }
//                 }
//             }
            
//             void PrintArray(int[,] array)
//             {
//                 for (int i = 0; i < array.GetLength(0); i++)
//                 {
//                     Console.Write("[ ");
//                     for (int j = 0; j < array.GetLength(1); j++)
//                     {
//                         Console.Write(array[i, j] + " ");
//                     }
//                     Console.Write("]");
//                     Console.WriteLine("");
//                 }
//             }
//         }
//     }
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;

namespace task58
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = ReadInt("Введите количество строк: ");
            int columns = ReadInt("Введите количество столбцов: ");
            int[,] array = new int[rows, columns];
            int[,] secondArray = new int[rows, columns];
            int[,] resultArray = new int[rows, columns];
            
            FillArrayRandom(array);
            PrintArray2D(array);
            
            Console.WriteLine();
            
            FillArrayRandom(secondArray);
            PrintArray2D(secondArray);
            
            Console.WriteLine();
            
            if (array.GetLength(0) != secondArray.GetLength(1))
            {
                Console.WriteLine(" Нельзя перемножить ");
                return;
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    resultArray[i, j] = 0;
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                       resultArray[i, j] += array[i, k] * secondArray[k, j];
                    }
                }
            }
            
            PrintArray2D(resultArray);
            
            
            
            // Функция ввода
            int ReadInt(string message)
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }
            
            // Функция заполнения массива рандомными числами от 1 до 9
            void FillArrayRandom(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(1, 10);
                    }
                }
            }
            
            // Функция вывода двумерного массива в терминал 
            void PrintArray2D(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }            
        }
    }
}
