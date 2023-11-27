// Задача 1

Console.Clear();
// Console.WriteLine("Введите число");
// int n1 = Convert.ToInt32(Console.ReadLine());
// while (n1 < 0 || n1 > 1000)
// {
//     Console.Write("Ошибка! Введите число: ");
//     n1 = Convert.ToInt32(Console.ReadLine());
// }
// if (n1 % 7 == 0 && n1 % 23 == 0)
//     Console.WriteLine("Введенное число " + n1 + " кратно 7 и 23");
// else
//     Console.WriteLine("Введенное число " + n1 + " не кратно одновременно 7 и 23");

// Задача 2
// Console.Write("Введите координаты Х:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты Y:");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x>0 && y>0) Console.Write("Координаты лежат в I четверти");
// else if (x<0 && y>0) Console.Write("Координаты лежат в II четверти");
// else if (x<0 && y<0) Console.Write("Координаты лежат в III четверти");
// else if (x>0 && y<0) Console.Write("Координаты лежат в IV четверти");
// else Console.WriteLine("Точка находится на оси координат");

// Задача 3
// Console.WriteLine("Введите число от 10 до 99");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 10 || n > 99)
// {
//      Console.Write("Ошибка! Введите число: ");
//      n = Convert.ToInt32(Console.ReadLine());
//  }
// if (n/10 > n%10) 
//     Console.WriteLine("Наибольшая цифра "+n/10);
// else 
//     Console.WriteLine("Наибольшая цифра "+n%10);

//Задача 4
// Console.WriteLine("Введите натуральное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 0)
// {
//     Console.Write("Ошибка! Введите натуральное число: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }

// if (n < 10) Console.Write(n);
// else
// {
//     int max = Convert.ToString(n).Length;
//     int deg=1;
//     while (max > 1)
//     {
//         for (int pow=1; pow<max; pow++) deg*=10;
//         Console.Write(n/deg + ",");
//         n = n % deg;
//         deg=1;
//         max--;
//         if (max == 1) Console.Write(n);
//     }

// }


