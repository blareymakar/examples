// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.

// string PrintNumbers(int n, int m)
// {
//     if (n == m-1)
//         return "";
//     return PrintNumbers(n - 1, m) + $"{n} ";
// }

//Console.Clear();
// Console.Write("Введите натуральное число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите натуральное число M<N: ");
// int m = Convert.ToInt32(Console.ReadLine());
// while (m>n||m<=0)
//     {
//         Console.WriteLine($"Число {m} некорректное: введите корректное значение!");
//         m = Convert.ToInt32(Console.ReadLine()); 
//     }
// Console.WriteLine(PrintNumbers(n, m));


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int AckFunction(int N, int M)
// {
//     if (N==0) return M+1;
//     else if (M==0) return AckFunction(N - 1, 1);
//     else return AckFunction(N - 1, AckFunction(N, M - 1)); 
// }

// Console.Clear();
// Console.Write("Введите число N функции Аккермана: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Функция Аккермана возвращает значение: {AckFunction(n, m)}");

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void PrintArrayRecurs(int[] arr, int i)
{

    if (i >= 0)
    {   if (i==arr.Length-1) Console.Write("[");
        Console.Write(arr[i]);
        if (i != 0) Console.Write(", ");
        else Console.Write("]");
        PrintArrayRecurs(arr,i-1); 
    }
}

Console.Clear();
Console.Write("Введите длину массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100);
Console.WriteLine($"Задан массив[{string.Join(", ", array)}]");
Console.Write("Вывод элементов с конца рекурсией: ");
PrintArrayRecurs(array, array.Length - 1);