// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isEven = number % 2 == 0;

if (isEven)
{
    Console.WriteLine("Число является четным.");
}
else
{
    Console.WriteLine("Число не является четным.");
}