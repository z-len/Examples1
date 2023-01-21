// Написать программу ввода числа, которая на выходе выдает его квадрат
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()); // конвертация строки в целочисленный тип

// 1. Математическое решение

int num = number * number;
Console.WriteLine($"Квадрат числа {number} равен {num}.");

// Решение через библиотеку
int num2 = Convert.ToInt32(Math.Pow(number, 2));

Console.WriteLine($"Квадрат числа {number} равен {num2}.");



