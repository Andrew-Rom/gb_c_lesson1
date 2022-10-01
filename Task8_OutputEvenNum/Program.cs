// Задача 8
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("ЗАДАЧА 8");
Console.Write("Введите число N: ");

int n = int.Parse(Console.ReadLine());
if (n == 1)
{
    Console.WriteLine("Четных чисел нет");
}
else
{ 
    int[] numbers = new int[n];

    for (int i = 0; i < n; i++)
    {
        numbers[i] = i + 1;
    }
    string evenNumbers = "";
    
    for (int i = 0; i < n; i++)
    {
        if (numbers[i] % 2 == 0)
            {
                evenNumbers = evenNumbers + numbers[i].ToString() + ", "; 
            }
    }

    evenNumbers = evenNumbers.Remove(evenNumbers.Length-2); // Удаление лишней запятой
    Console.WriteLine(evenNumbers);
}