// Задача 2
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("ЗАДАЧА 2");
Console.Write("Введите первое число: ");
string value1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string value2 = Console.ReadLine();
int a = int.Parse(value1);
int b = int.Parse(value2);
if (a > b)
{
    Console.WriteLine($"max = {a}, min = {b}");
}
else if (b > a)
{
    Console.WriteLine($"max = {b}, min = {a}");
}
else
{
    Console.WriteLine("Числа равны");
}
