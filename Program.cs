// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// System.Console.WriteLine("Введите пятизначное число: ");
// string number = Console.ReadLine()!;
// int Length = number.Length;

// if (number.Length == 4)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//         System.Console.Write($"{number} - число является палиндромом");

// else

//     System.Console.Write($"{number} - число не является палиндромом");
// }
// else
// {
//     System.Console.Write($"{number} - число не является пятизначным");
// }







// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// double Distance(int [] a, int [] b)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2) + Math.Pow(a[2] - b[2], 2)), 2);
// }

// int[ ] a = new int[3];
// int[ ] b = new int[3];

// a[0] = ReadInt("Введите координату X точки А: ");
// a[1] = ReadInt("Введите координату Y точки A: ");
// a[2] = ReadInt("Введите координату Z точки A: ");
// b[0] = ReadInt("Введите координату X точки B: ");
// b[1] = ReadInt("Введите координату Y точки B: ");
// b[2] = ReadInt("Введите координату Z точки B: ");
// double res = Distance(a, b);

// System.Console.WriteLine("Расстояние между точками =" + res);







// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int number = ReadInt("Введите число: ");
// for(int i=1;i<=number; i++)
// {
//     System.Console.Write(Math.Pow(i,3)+ " " );
// }