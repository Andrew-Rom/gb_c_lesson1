// Задача 6
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.

Console.WriteLine("ЗАДАЧА 6");
Console.Write("Введите число: ");
int checkNum = int.Parse(Console.ReadLine());
if (checkNum % 2 == 0)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}