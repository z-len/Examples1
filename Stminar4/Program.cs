// // Написать программу, которая принимает на вход число А 
// //и выдает сумму чисел от 1 до А


// //  пишем функцию
// int GetSum(int A)
// {
//     int sum = 0;// это счетчик, который в начале обнулен
//     for(int i = 1; i<=A; i++) // идем по всем значениям от 1 до n (то есть А)
//     {
//         sum+=i;// и складывает эти значения
//     }
//     return sum; //возвращаем значение суммы
// }   

// Console.Write("Введите А: ");
// int n = int.Parse(Console.ReadLine());// пользователь вводит число
// int sum = GetSum(n); // вызываем фуркцию
// Console.WriteLine($"{sum}"); // выводим на экран результат

// Написать программу, которая принимает на вход число и 
// и выдает количество цифр в числе

// int result(int number)
// {
//     if(number<0) number = number*-1;
//     int count = 0;
//     while(number>0)
//     {
//         number /= 10;
//         count++;
//     }
//     return count;
// }

// void main()
// {
//     Console.Write("Введите число: ");
//     int num = int.Parse(Console.ReadLine()!);
//     Console.WriteLine(result(num));
// }
// main();


// // Написать программу, которая принимает на вход число N 
// // //и выдает произведение чисел от 1 до N

// int GetMult(int N)
// {
//     int mult = 1;// это счетчик, в который вначале кладу 1, иначе произведение
//     // будет равно 0
//     for(int i = 1; i<=N; i++) // идем по всем значениям от 1 до n (то есть А)
//     {
//         mult=mult*i;// и складывает эти значения
//     }
//     return mult; //возвращаем значение суммы
// }   
// void fin()
// {
//     Console.Write("Введите число: ");
//     int n = int.Parse(Console.ReadLine()!);// пользователь вводит число
//     Console.WriteLine(GetMult(n)); // выводим на экран результат
// }
// fin();

// Напишите программу, которая выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке

// Console.Clear();
// void FillArray(int[] collection)
// {
//     int Length = collection.Length;
//     int index = 0;
//     while(index<Length)
//     {
//         collection[index] = new Random().Next(0, 2);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while(position<count)
//     {
//         Console.Write(col[position] );
//         position++;
//     }
// }

// int[] array = new int[8]; // это значит "создай новый массив, в котором будет 10 элементов
// // по умолчанию он будет наполнен нулями

// FillArray(array);
// PrintArray(array);
// //Console.WriteLine(String.Join(", ", array)); // второй вариант вывода через 
// //запятую, вместо PrintArray(array);


  


