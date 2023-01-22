// Программа, которая выводит случайное число из отрезка [10, 99] и показывает наибольшу цифру этого числа
Console.Clear();
// int num = new Random().Next(10, 100);

// int a1 = num/10;// первая цифра числа
// int a2 = num%10;// вторая цифра числа

// int max = a1;
// if(a2>max) max=a2;

// Console.WriteLine($"Максимальная цифра числа {num} - это {max} ");

// // Программа, которая выводит случайное трехзначное число и уудаляет вторую цифру этого числа
// int num = new Random().Next(100, 1000);

// int a1 = num/100;// первая цифра числа
// int a2 = num%10;// вторая цифра числа

// Console.WriteLine(num);
// Console.WriteLine($"{a1}{a2}");

// Программа принимает на вход два числа и выводит является ли второе число кратное первому, если некратно, то выводит остаток от деления

// Console.WriteLine("Введите два числа: ");
// int n1 = int.Parse(Console.ReadLine());
// int n2 = int.Parse(Console.ReadLine());
// if(n1%n2 ==0) 
// {Console.WriteLine($"Число {n2} кратно {n1}. ");}
// int m = n1%n2;
// if(m!=0) 
// {Console.WriteLine($"Не кратно, остаток {m}. ");}

// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно
// 7 и 23.
// ● 14 -> нет
// ● 46 -> нет
// ● 161 -> да

// Console.WriteLine("Введите число: ");
// int b1 = int.Parse(Console.ReadLine());

// if(b1%7==0 & b1%23==0)
// {
//     {Console.WriteLine($"Число {b1} кратно 7 и 23. ");}
// }
// else
// {
//     Console.WriteLine("Нет.");
// }
// Напишите программу, которая принимает на вход два
// числа и проверяет, является ли одно число квадратом
// другого.

Console.WriteLine("Введите два числа: ");
int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
if(x2==(x1*x1))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}