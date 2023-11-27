// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// string f= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f+10);

// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a == b * b)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int i = n * (-1);
// while (i <= n)
// {
//     Console.Write(i + " ");
//     i ++;
// }

// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1 = n / 100;
// int n3 = n % 10;
// Console.WriteLine(n1 + n3);



Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("О, Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}



Console.Clear();

// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 (5*5*5*5)= 625
// 617 => 1

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// while(n < 100 || n > 999){
//     Console.Write("Ошибка! Введите число: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }

// // 514 / 10 = 51(4 ost) -> 51 % 10 = 5(1 ost) -> 1
// int n2 = n / 10 % 10;
// int n3 = n % 10;  // 514 % 10 = 51(4 ost) -> 4

// // n2 = 3
// // n3 = 5
// // 3 * 3 * 3 * 3 * 3 = 243
// int result = 1;
// for (int i = 1; i <= n3; i ++)
// {
//     result *= n2;
// }
// Console.WriteLine("Loop: " + result);
// Console.WriteLine(Math.Pow(n2, n3));

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// while(n < 100 || n > 999){
// Console.Write("Ошибка! Введите число: ");
// n = Convert.ToInt32(Console.ReadLine());
//  }
// int n1 = n / 100;
// int n3 = n % 10;

// Console.WriteLine(n1+""+n3);

// int n = new Random().Next(100, 1000); // [100, 999]
// Console.WriteLine("Random = " + n);
// int n1 = n / 100;
// int n3 = n % 10;
// Console.WriteLine(n1 * 10 + n3);
int n1 = new Random().Next(0, 100);
Console.WriteLine("Random1 = " + n1);
int n2 = new Random().Next(0, 100);
Console.WriteLine("Random2 = " + n2);
if (n1 % n2 == 0)  Console.WriteLine("Да");   
else     Console.WriteLine("Нет, " + n1 % n2);

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 100)
    Console.WriteLine("Третьей цифры нет");
else
{   // 1234567 / 10 = 123456 / 10 = 12345 / 10 = 1234 / 10 = 123
    while(n > 999)
        n /= 10; // n = n / 10
    Console.WriteLine(n % 10);
}