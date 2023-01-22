// // Написать программу ввода числа, которая на выходе выдает его квадрат
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()); // конвертация строки в целочисленный тип

// // 1. Математическое решение

// int num = number * number;
// Console.WriteLine($"Квадрат числа {number} равен {num}.");

// // Решение через библиотеку
// int num2 = Convert.ToInt32(Math.Pow(number, 2));

// Console.WriteLine($"Квадрат числа {number} равен {num2}.");


// // На вход принимаем число n, на выходе дает все целые числа в промежутке от -n до n

// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// int count = -n;
// while(count<=n)
// {
//    Console.WriteLine(count);
//     count++;
// }

//Написать программу, которая на вход принимает трехзначное число и на выходе дает последнюю цифру данного числа
Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());
int result = n%10;
Console.Write(result);


