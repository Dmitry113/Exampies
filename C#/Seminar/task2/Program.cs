﻿// Задача №1. Напишите программу, которая на вход принимает два числа и
// проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 == (number2 * number2))
{
    Console.Write($"Первое число {number1} является квадратом числа {number2}");   
}
else
{
    Console.Write($"Первое число {number1} Не является квадратом числа {number2}"); 
}