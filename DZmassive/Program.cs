//Задача 1.Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// Console.Clear();
// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 101);  // [1, 100]
// Console.WriteLine($"Задан массив [{string.Join(", ", array)}]");
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] >= 20 && array[i] <= 90) count++;
// }

// Console.WriteLine($"Количество элементов массива в диапазоне [20,90]: {count}");


//Задача 2: Задайте массив из 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
// Console.Clear();
// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 1000);  // [1, 999]
// Console.WriteLine($"Задан массив [{string.Join(", ", array)}]");
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0) count++;
// }

// Console.WriteLine($"Количество четных элементов в массиве равно {count}");

//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.
// Console.Clear();
// Console.Write("Введите длину массива: ");
// int x = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[x];
// for (int i = 0; i < array.Length; i++)
//     array[i] = Math.Round(new Random().NextDouble(),2) + new Random().Next(1, 100);  // [1.  , 99]
// Console.WriteLine($"Задан массив[{string.Join("; ", array)}]");
// Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {array.Max() - array.Min()}");

// Задача 4: дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем.

// Console.Clear();
// Console.Write("Введите натуральное число в диапазоне от 1 до 100 000: ");

// int num = Convert.ToInt32(Console.ReadLine());
// while(num < 0 || num > 100000)
// {
//     Console.Clear();
//     Console.Write("Введите натуральное число в диапазоне от 1 до 100 000: ");
//     num = Convert.ToInt32(Console.ReadLine());
// }

// int[] array = new int[Convert.ToString(num).Length];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = num / Convert.ToInt32(Math.Pow(10, array.Length - i - 1));
//     num %= Convert.ToInt32(Math.Pow(10, array.Length - i - 1));
// }
// Console.WriteLine($"Массив [{string.Join(", ", array)}]");
