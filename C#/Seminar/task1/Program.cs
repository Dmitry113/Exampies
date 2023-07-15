// Задача №3. Напишите программу, которая будет выдовать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число: ");

int number1 = int.Parse(Console.ReadLine());
if (number1 == 1) Console.WriteLine("Сегодня Понедельник");
if (number1 == 2) Console.WriteLine("Сегодня Вторник");
if (number1 == 3) Console.WriteLine("Сегодня Среда");
if (number1 == 4) Console.WriteLine("Сегодня Четверг");
if (number1 == 5) Console.WriteLine("Сегодня Пятница");
if (number1 == 6) Console.WriteLine("Сегодня Суббота");
if (number1 == 7) Console.WriteLine("Сегодня Воскресенье");
else
{
    Console.WriteLine("Сказано же, ведите число от 1 до 7");
}

