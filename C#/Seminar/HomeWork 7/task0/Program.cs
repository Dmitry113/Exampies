//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


using System;

class Program
{
    static void Main()
    {
        // Задаем размер массива
        int[] array = new int[4];

        // Заполняем массив случайными трехзначными числами
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        // Выводим содержимое массива
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Получаем количество четных чисел
        int evenCount = CountEvenNumbers(array);

        // Выводим результат
        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }

    // Метод для вывода массива на экран
    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    // Метод для подсчета четных чисел в массиве
    static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (var number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}


