// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int ostatok = number1 % number2;
if (number1 % number2 == 0)
 {
    Console.WriteLine($"Число {number2} кратно числу {number1}");
 }
else
{
Console.WriteLine($"Число {number2} не кратно числу {number1}. Остаток от деления {number1} на {number2} равен {ostatok}");
}


