// Задача 4
//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("ЗАДАЧА 4");
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());
int [] numbers = {num1, num2, num3};
int maxNumber = numbers [0];
for (int i = 0; i < 3; i++)
{
    if (numbers[i] > maxNumber) maxNumber = numbers[i];
}
Console.WriteLine($"Максимальное из этих чисел: {maxNumber}");
