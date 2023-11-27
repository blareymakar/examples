// // Поиск простых чисел в массиве

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10);
    //Console.WriteLine(string.Join(", ", array));

}

// // bool CheckSimple(int x)
// // {
// //     for(int i=2; i<x; i++)
// //     if (x%i ==0 ) return false;
// //     return true;

// // }
// bool CheckCond(int x)
// {

//     if (x%10 ==1 && x%7==0 ) return true;
//     return false;

// }

// void ReleaseArray(int[] array)
// {
//     int count=0;
//     for (int i = 0; i < array.Length; i++)
//     if (CheckCond(array[i])==true) count++;
//     Console.WriteLine(count);

// }

int ArraytoInt(int[] array)
{
    int x = array[0];
    for (int i = 1; i < array.Length; i++)
        x = x * 10 + array[i];
    //Console.WriteLine(x);
    return x;
}

Console.Clear();
Console.Write("Введите число элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine(string.Join(", ", array));
// ReleaseArray(array);
int res = ArraytoInt(array);
Console.WriteLine(res);
Console.WriteLine(res.GetType());
int res2 = Convert.ToInt32(string.Join("", array));
Console.WriteLine(res2);

// // Найти в массиве N количество чисел, которые оканчиваются на 1 и делятся нацело на 7

