// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine()!);

if (a > b)
    if (a > c)
{
    Console.WriteLine($"{a}");
}
if (b > a)
    if (b > c)
{
    Console.WriteLine($"{b}");
}
if (c > a)
    if (c > b)
{
    Console.WriteLine($"{c}");
}