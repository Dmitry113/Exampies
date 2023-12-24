//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение m: ");
        if (int.TryParse(Console.ReadLine(), out int m))
        {
            Console.Write("Введите значение n: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int result = AckermannFunction(m, n);
                Console.WriteLine($"A({m}, {n}) = {result}");
            }
            else
            {
                Console.WriteLine("Введите корректное целочисленное значение для n.");
            }
        }
        else
        {
            Console.WriteLine("Введите корректное целочисленное значение для m.");
        }
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
        else
        {
            return 0; // В случае некорректных входных данных
        }
    }
}

