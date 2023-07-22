// Напишите программу,которая выводит случайное число из отрезка [10, 99] и
// показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 5

// Сгенерировать число в промежутке от 10 до 99
// Разделить одно число на две цифры
// Сравнить и вывести большее

int number = new Random().Next(10,100);
int firstDigit = number / 10;
int secondDigit = number % 10;
int max = firstDigit;
if (max < secondDigit)
{
    max = secondDigit;
}
Console.WriteLine($"Максимальная цифра в числе {number} -> {max}");
