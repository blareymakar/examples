// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.


void InputMatrix(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
        for (int j = 0; j < massive.GetLength(1); j++)
            massive[i, j] = new Random().Next(0, 10);
}

void PrintMatrix(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
            Console.Write(massive[i, j] + "\t");
        Console.WriteLine();
    }
}

// void CoordToMean(int[,] massive)
// {
//     Console.Write($"Введите номер строки от 0 до {massive.GetLength(0)-1}: ");
//     int x = Convert.ToInt32(Console.ReadLine());
//     Console.Write($"Введите номер столбца от 0 до {massive.GetLength(1)-1}: ");
//     int y = Convert.ToInt32(Console.ReadLine());
//     if (x < massive.GetLength(0) && y < massive.GetLength(1))
//         Console.WriteLine($"Значение элемента массива [{x},{y}] равно {massive[x, y]}");
//     else Console.WriteLine($"Элемента массива [{x},{y}] не существует");
// }

// Console.Clear();
// Console.Write("Введите размеры матрицы через пробел: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// CoordToMean(matrix);

//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// void StringsExchange(int[,] massive)
// {   int temp=0;
//     for(int i=0; i<massive.GetLength(1);i++)
//     {
//         temp=massive[0,i];
//         massive[0,i]=massive[massive.GetLength(0)-1,i];
//         massive[massive.GetLength(0)-1,i] = temp;
//     }

// }

// Console.Clear();
// Console.Write("Введите размеры матрицы через пробел: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// StringsExchange(matrix);
// PrintMatrix(matrix);

//Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// void MinSumString(int[,] matrix)
// {
//     int sum = 0, min_sum = 0, i_min = 0;
//     int[] array = new int[matrix.GetLength(0)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i, j];
//         }
//         array[i] = sum;
//     }
//     Console.WriteLine(string.Join(", ", array));
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == array.Min()) Console.WriteLine($"Строка с индексом {i} имеет наименьшую сумму элементов");
//     }
// }

// Console.Clear();
// Console.Write("Введите размеры матрицы через пробел: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// MinSumString(matrix);

//Задача 4: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива. 
//Под удалением понимается создание нового двумерного массива без строки и столбца

int FindMin(int[,] matrix)
{
    int min = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min) min = matrix[i, j];
        }

    }
    return min;

}

int MinCount(int[,] matrix, int min)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == min) count++;
        }

    }
    Console.WriteLine($"Минимальное значение {min} встречается в массиве {count} раз");
    return count;
}

(int, int) MinPos(int[,] matrix, int min, int count)
{
    int mini = -1, minj = -1;
    if (count > 1)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

                if (matrix[i, j] == min)
                {
                    Console.WriteLine($"Обнаружено минимальное число {matrix[i, j]} в позиции [{i},{j}]");
                    Console.WriteLine("Введите 'yes', если хотите использовать его, или 'no', если хотите перейти к следующему");
                    string input = "";
                    while (input != "yes" && input != "no")
                    {
                        input = Console.ReadLine();
                    }
                    if (input == "yes") { mini = i; minj = j; goto exit; }

                }
            }
        }
    exit:;
    }
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

                if (matrix[i, j] == min)
                { mini = i; minj = j; }
            }
        }
        Console.WriteLine($"Обнаружено минимальное число {min} в позиции [{mini},{minj}]");
    }
    if (mini == -1) Console.WriteLine("Вы не выбрали минимальное число из предложенных вариантов, массив не преобразован");
    //else Console.WriteLine($"mini={mini}, minj={minj}");

    return (mini, minj);
}


int[,] ExcludeElement(int[,] matrix, int mini, int minj)
{
    int[,] arraystring = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
    for (int i = 0, i1 = 0; i < matrix.GetLength(0); i++)
    {
        if (i != mini)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                arraystring[i1, j] = matrix[i, j];
            }
            i1++;
        }
    }

    int[,] array = new int[arraystring.GetLength(0), arraystring.GetLength(1) - 1];
    for (int i = 0; i < arraystring.GetLength(0); i++)
    {
        for (int j = 0, j1 = 0; j < arraystring.GetLength(1); j++)
        {
            if (j != minj)
            {
                array[i, j1] = arraystring[i, j];
                j1++;
            }
        }
    }


    return array;
}



Console.Clear();
Console.Write("Введите размеры матрицы через пробел: ");
int posi = 0, posj = 0, min;
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
if (matrix.GetLength(0) < 2) Console.WriteLine("Всего одна строка в массиве, преобразование массива невозможно!");
else if (matrix.GetLength(1) < 2) Console.WriteLine("Всего один столбец в массиве, преобразование массива невозможно!");
else
{
    min = FindMin(matrix);
    (posi, posj) = MinPos(matrix, min, MinCount(matrix, min));
    //Console.WriteLine($"Индекс i={posi}, j={posj}");
    if (posi >0)    PrintMatrix(ExcludeElement(matrix, posi, posj));
}
