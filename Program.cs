// See https://aka.ms/new-console-template for more information
using System;

//Задача 1
//
// void Main()
// {
//     int M = ReadInt("Введите меньшее число: ");
//     int N = ReadInt("Введите большее число: ");
//     PrintNumber(M, N);
// }

// void PrintNumber(int M, int N)
// {
//     if(M > N) return;
//     Console.Write(M + " ");
//     PrintNumber(M + 1, N);
// }

// int ReadInt(string msg)
// {
//     Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Main();

//Задача 2
//
// void Main()
// {
//     int m = ReadInt("Введите m: ");
//     int n = ReadInt("Введите n: ");
//     Console.WriteLine(Akker(m, n));
// }

// long Akker(long m, long n)
// {
//     long A = 0;
//     if(m == 0) 
//         A = n + 1;
//     else if (n == 0 && m > 0)
//         A = Akker (m - 1, 1);
//     else
//         A = Akker (m - 1, Akker (m, n - 1));
//     return A;
// }

// int ReadInt(string msg)
// {
//     Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Main();

//Задача 3.
//
// Здесь простите, цикл руками закладываю, потому что написано, что без циклов. А генерить ещё и цикл рекурсией мне лень).
//
void Main()
{
    int[] array = {1,5,4,2,5,7,24,26,23525,362,26,1,5,6,7,2,5,4,1456};
    int n = array.GetLength(0) - 1;
    antiarray(array, n);
}

void antiarray(int[] array, int n)
{
    if(n < 0) return;
    Console.Write(array[n] + " ");
    n--;
    antiarray(array, n);
}

Main();
