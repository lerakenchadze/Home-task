// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


// void Palindrom(int n)
// {
//     int f = 0;
//     int v = 0;
//     if (n > 9999 & n < 1000000)
//     {
//         while (f == v)
//         {
//             f = n / 1000;
//             v = n % 10;
//             Console.WriteLine("да");
//         }
//     Console.WriteLine("нет");
//     }    
//     else 
//         Console.WriteLine("Вы ввели не пятизначное число!!!");  
// }

// Console.Write("Введите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Palindrom(n);

// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// void Dist (int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     double d = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
//     Console.WriteLine($"Расстояние: {Math.Round(d,2)}");
// }

// Console.WriteLine("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// Dist(x1, x2, y1, y2, z1, z2);

// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Kub(int N)
// {
//     for (int N1 = 1; N1 <= N; N1++)
//     {
//         Console.Write(N1*N1*N1 + " ");
//     }
// }

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Kub(N);


