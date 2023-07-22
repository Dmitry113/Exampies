//Задача №11. Напишите программу, которая выводит случайное трёхзначное число и
// удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int rondom = new Random().Next(100, 1000);
int firstDigit = rondom / 100;
int thirdDigit = rondom % 10;

Console.WriteLine($"{rondom} -> {firstDigit }{thirdDigit}");