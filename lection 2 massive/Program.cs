int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// 5 4 1 2
// "5 4 1 2"
// "5", "4", "1", "2"
// 5, 4, 1, 2
// [5, 4, 1, 2]
Console.WriteLine(string.Join(", ", array));


void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}



Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine(string.Join(", ", array));
InputMatrix(matrix);
PrintMatrix(matrix);



// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
// 4 3 4 1 =>
// 2 9 5 4

// 4 3 16 3
// 4 3 4 1
// 4 9 25 4


void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                Console.Write(matrix[i, j] * matrix[i, j] + "\t");
            else
                Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine(string.Join(", ", array));
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Новый массив: ");
ReleaseMatrix(matrix);


void ReleaseMatrix(int[,] matrix)
{
    int sum=0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum+=matrix[i,j]
                
        }
        
    }
    Console.WriteLine(sum);
}

void ReleaseMatrix(int[,] matrix)
{
    int summa = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
                summa = summa + matrix[i, j];
        }
    }
    Console.WriteLine(summa);
}


Задайте двумерный массив из целых чисел. Сформируйте новый
одномерный массив, состоящий из средних арифметических
значений по строкам двумерного массива.
Пример
2 3 4 3
4 3 4 1 => [3 3 5]
2 9 5 4

void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11);
}


void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}


int[] ReleaseMatrix(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int summa = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        summa = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            summa = summa + matrix[i, j];
        }
        array[i] = summa / matrix.GetLength(1);
    }
    return array;
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] array = new int[size[0]];
InputMatrix(matrix);
PrintMatrix(matrix);

array = ReleaseMatrix(matrix);
Console.WriteLine(string.Join(", ", array));