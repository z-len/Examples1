/*Задача 46: Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1*/
// 

// // Метод для заполнения двумерного массива
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     // нужно для запонения использовать два цикла: один будет бегать
//     // по строчкам - это i, а другой по столбцам - это j
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++) 
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
// // Метод печати двумерного массива
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]}\t");
//         }
//         Console.WriteLine();// для формирования таблицы
//     }
// }

// Console.Clear();

// Console.Write("Введите количество строк: ");
// int row = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int col = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(row, col, 0, 10);
// PrintArray(array);

/* Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aij = i+j.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/

// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++) 
//         {
//             result[i, j] = i+j;
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();


// int[,] array = GetArray(5, 5);
// PrintArray(array);

/*Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть
вот так:
1 4 49 2
5 81 2 9
64 4 4 4
*/
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++) 
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void Change(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i+=2)
//     {
//         for (int j = 0; j < array.GetLength(1); j+=2)
//         {
//             array[i, j] *= array[i, j];
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Clear();


// Console.Write("Введите количество строк: ");
// int row = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int col = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(row, col, -100, 100);
// PrintArray(array);
// Console.WriteLine();
// Change(array);
// PrintArray(array);

/*Задача 51: Задайте двумерный массив.
Найдите сумму элементов, находящихся на главной диагонали (с
индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Сумма элементов главной
диагонали: 1+9+2 = 12*/

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++) 
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int Summ(int[,] arr)
// {
        
//         int summ = 0;
//         for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
            
//             if(i==j) summ = summ + arr[i,j];
//         }
        
//     }
//     return summ;
// }

// Console.Clear();

// Console.Write("Введите количество строк: ");
// int row = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int col = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(row, col, 0, 20);
// PrintArray(array);
// Console.WriteLine();

// int result = Summ(array);
// Console.WriteLine(result);

