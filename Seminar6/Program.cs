/* Задача 39: Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

// Напишем функцию, которая генерирует случайные числа

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++) 
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// // Создадим функцию, которая будет переворачивать массив, она не будет ничего
// // возвращать, принимать будет исходный массив
// void ReversArray(int[] inArray)
// {
//     for(int i=0; i<inArray.Length / 2; i++)// идем до середины массива
//     {
//         int temp = inArray[i];// создаем временную переменную (третью кружку) и
//         //кладем в него первый элемент
//         inArray[i]=inArray[inArray.Length-1-i];// теперь в первый элемент кладем
//         // последний элемент массива, потом во второй - предпоследний и т.д.
//         inArray[inArray.Length-1-i] = temp; // теперь в последний (предпоследний...)
//         // кладем элемент из временной переменной (третьей кружки)
//     }
// }
// int[] array = GetArray(11, 0, 10);
// Console.WriteLine(String.Join(" ", array));
// ReversArray(array);
// Console.WriteLine(String.Join(" ", array));

// 
/*Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.*/

// bool Triangl(int a, int b, int c)
// {
//     return a<b+c&&b<a+c&&c<a+b;
// }
// Console.Clear();
// Console.Write("Введите длину первой стороны: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите длину второй стороны: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите длину третьей стороны: ");
// int c = int.Parse(Console.ReadLine());

// bool answer = Triangl(a, b, c);
// if(answer)
// {
//     Console.WriteLine("Такой треугольник существует.");
// }
// else
// {
//     Console.WriteLine("Такой треугольник не существует.");
// }


/*Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/

// void main()
// {
//     Console.Write("Введите число: ");
//     int inputNamber = int.Parse(Console.ReadLine()); // вводим число
//     string ReversInt = Return01(inputNamber); // теперь переменную строки в которую
//     // передаем функцию, котора вернут строку (написано ниже)
//     Console.WriteLine(ReversInt);
// }

// string Return01(int number)
// {
//     string number01 = string.Empty;
//     while(number>0)
//     {
//         number01 = (number % 2).ToString()+ number01;
//         number /=2;
//     }
//     return number01;
// }
// main();

/*Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

// void WriteFibonacci(int number)
// {
//     int FirstFib = 0;
//     int SecondFib = 1;
//     for(int i = 1; i<number; i++)
//     {
//         Console.WriteLine(FirstFib);
//         int temp = SecondFib;
//         SecondFib = FirstFib+SecondFib;
//         FirstFib = temp;
//     }
// }

// void Main() 
// {
//     Console.Write("Введите число: ");
//     int inputNamber = int.Parse(Console.ReadLine());
//     WriteFibonacci(inputNamber);
// }
// Main();

/*Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++) 
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int[] CopyArray(int[] array)
{
    int[] arrayClone = new int [array.Length];
    for(int i=0; i<array.Length; i++)
    {
        arrayClone[i]=array[i];
    }
    return arrayClone;
}
Console.Clear();
int[] array = GetArray(10, 0, 10);
int[] arrayClone = CopyArray(array);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine(string.Join(" ", arrayClone));