Console.Clear();

// // Задача №17. Напишите программу, которая
// // принимает на вход координаты точки (X и Y),
// // причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
// // плоскости, в которой находится эта точка.

// Console.Write("Введите x: ");
// int x = int.Parse(Console.ReadLine());
// Console.Write("Введите y: ");
// int y = int.Parse(Console.ReadLine());
// if(y>0)
// {
//     if(x>0)
//     {
//       Console.WriteLine("Первая четверть");
//     }
//     else
//     {
//       Console.WriteLine("Вторая четверть");  
//     }
// }
// else
// {
//     if(x>0)
//     {
//       Console.WriteLine("Четвертая четверть");
//     }
//     else
//     {
//       Console.WriteLine("Третья четверть");  
//     }
// }

// Задача №18. Работа в группах
// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

// Console.Write("Введите номер четверти (1-4): ");
// int n = int.Parse(Console.ReadLine());
// if (n == 1)
// {
//     Console.Write("x - положительное, y - положительное");
// }
// if (n == 2)
// {
//     Console.Write("x - отрицательное, y - положительное");
// }
// if (n == 3)
// {
//     Console.Write("x - отрицательное, y - отрицательное");
// }
// if (n == 4)
// {
//     Console.Write("x - положительное, y - отрицательное");
// }

//Та же задача через конструкцию switch case

// Console.Write("Введите номер четверти (1-4): ");
// int n = int.Parse(Console.ReadLine());
// switch (n)
// {
//     case 1:
//         {
//             Console.Write("x - положительное, y - положительное");
//             break;
//         }
//     case 2:
//         {
//             Console.Write("x - отрицательное, y - положительное");
//             break;
//         }
//     case 3:
//         {
//             Console.Write("x - отрицательное, y - отрицательное");
//             break;
//         }

//     case 4:
//         {
//             Console.Write("x - положительное, y - отрицательное");
//             break;
//         }
//     default:
//         {
//             Console.Write("Введена неправильная четверть");
//             break;
//         }

// }

// Задача №21. Работа в группах
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите координаты первой точки: x: ");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты первой точки: y: ");
// double y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты второй точки: x: ");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты второй точки: y: ");
// double y2 = Convert.ToInt32(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
// result = Math.Round(result, 2);
// Console.WriteLine(result);

// Задача №22. Работа в группах
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int count = 1;
while(count<=N)
{
    int sqr=Convert.ToInt32(Math.Pow(count,2));
    Console.WriteLine(sqr);
    count++;
}