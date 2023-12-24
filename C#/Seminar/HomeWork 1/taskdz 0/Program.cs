//Программа которая принимает на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа

//456 -> 5
//782 -> 8
//918 -> 1


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трёхзначное число:");
        string input = Console.ReadLine();

        if (input.Length == 3 && int.TryParse(input, out int number))
        {
            int secondDigit = (number / 10) % 10;
            Console.WriteLine($"Вторая цифра числа {input}: {secondDigit}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите трёхзначное число.");
        }
    }
}
