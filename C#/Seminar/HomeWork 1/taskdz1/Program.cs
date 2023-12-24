//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        string input = Console.ReadLine();

        char thirdDigit = GetThirdDigit(input);

        if (thirdDigit != '\0')
        {
            Console.WriteLine($"Третья цифра: {thirdDigit}");
        }
        else
        {
            Console.WriteLine("Третьей цифры нет.");
        }
    }

    static char GetThirdDigit(string input)
    {
        // Проверка наличия третьей цифры в числе
        if (input.Length >= 3 && Char.IsDigit(input[2]))
        {
            return input[2];
        }
        else
        {
            return '\0';
        }
    }
}
