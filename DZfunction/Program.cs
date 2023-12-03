// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого
// чётная.
// bool Odd(int num)
// {
//     int sum = 0;
//     while (num > 0) // Вычисление суммы цифр числа
//     {
//         sum += num % 10; // Добавление последней цифры к сумме
//         num /= 10; // Удаление последней цифры из числа 
//     }

//     if (sum % 2 == 0) return true;
//     return false;
// }
// Console.WriteLine("Для выхода из программы введите число, сумма цифр которого четная, или 'q' для выхода: ");

// while (true) // Бесконечный цикл
// {

//     string input = Console.ReadLine(); // Чтение строки ввода пользователя
//     if (input == "q")
//     {
//         Console.WriteLine("Выход из программы: нажата q");
//         break;
//     }
//     int number;
//     if (int.TryParse(input, out number) && Odd(number) == true)
//     {
//         Console.WriteLine("Выход из программы: сумма цифр - четная");
//         break;
//     }

// }

//Задача 2
// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] = new Random().Next(100, 1000);  // [100, 999]

// }


// int OddCount(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0) count++;
//     }
//     return count;
// }

// Console.Clear();
// Console.Write("Введите длину массива: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[x];
// FillArray(array);
// Console.WriteLine($"Задан массив [{string.Join(", ", array)}]");
// Console.WriteLine($"Количество четных элементов в массиве равно {OddCount(array)}");

// Задача 3: Напишите программу, которая перевернёт одномерный массив 

// void ReverseArray(int[] arr)
// {
//     int temp = 0;
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         temp = arr[i];
//         arr[i] = arr[arr.Length - 1 - i]; 
//         arr[arr.Length - 1 - i] = temp;
//     }
// }

// Console.Clear();
// Console.Write("Введите длину массива: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[x];
// FillArray(array);
// Console.WriteLine($"Задан массив [{string.Join(", ", array)}]");
// ReverseArray(array);
// Console.WriteLine($"\nПеревернутый массив [{string.Join(", ", array)}]");