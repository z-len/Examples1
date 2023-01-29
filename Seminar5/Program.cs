// /* Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.*/

// // напишем функцию, которая принимает на вход: размер массива, инимальное значение
// // и максимальное значение массива

// int [] GetArray(int size, int minValue, int maxValue) // сигнатура метода
// {
//     int [] res = new int [size];// создаем массив, в который будем что-то 
//     //складывать. Создаем массив res с размером size
//     for(int i= 0; i<size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }
// int[] array = GetArray(12, -9, 9);
// Console.WriteLine(string.Join(" , ", array));// конструкция string.Join берет 
// // значения сторки и некий разделитель, по которому она будет склеивать значения
// // мы ей укажем в качестве разделителя пробел (в ковычках), а в качевстве второго 
// // значения она берет коллекцию, у нас это массив array. Таким образом у меня
// // должна сформироваться строка, элементы которой разделены запятыми с пробелами, а в качестве
// // самих элементов строки будут взяты элементы массмива array, который мы сгенерировали
// // с помощью нашей функции GetArray
// int sumNegativ = 0;
// int sumPositiv = 0;
// foreach(int el in array)

// {
//     // if (el<0) sumNegativ+=el;
//     // else sumPositiv+=el; 

//     // тернарный оператор сокращенная форма if else
// sumNegativ+=el<0?el:0; // если условие истино добавляем el, если ложно ничего не добавляем, то есть 0
// sumPositiv+=el>0?el:0; // если условие истино добавляем el, если ложно ничего не добавляем, то есть 0      
// }  
// Console.WriteLine($"Сумма отрицательных элементов = {sumNegativ}, сумма положительных = {sumPositiv}");

// Решение в группах задач:
// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// Console.WriteLine();
// int [] GetArray(int size, int minValue, int maxValue) 
// {
//     int [] res = new int [size];
//     for(int i= 0; i<size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }
// int[] array = GetArray(5, 0, 10);
// Console.WriteLine(string.Join(" | ", array));
// int len = array.Length;
// for (int index = 0; index<len; index++)
// {
//     array[index]*=-1;
// }
// Console.WriteLine(string.Join(" , ", array));


/*Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да*/

// Console.WriteLine();
// int [] GetArray(int size, int minValue, int maxValue) 
// {
//     int [] res = new int [size];
//     for(int i= 0; i<size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }
// int[] array = GetArray(5, 0, 10);
// Console.WriteLine(string.Join(" , ", array));

// Console.Write("Введите число:");
// int find = int.Parse(Console.ReadLine());
// int len = array.Length;
// for(int i=0; i<len; i++)
// {
//     if(array[i]==find) 
//     {
//         Console.WriteLine("Yes");
//         break;
//     }
//     else 
//     {
//         Console.WriteLine("No");
//         break;
//     }

// }

/*Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int CountElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] >= 10 && array[i] < 100)
        {
            count++;
        }
    }
    return count;
}
int[] array = GetArray(123, 0, 150);
Console.WriteLine(string.Join(" , ", array));
int count = CountElements(array);
Console.WriteLine($"-> {count}");