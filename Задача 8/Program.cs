//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Clear();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);
int n1 = 1;
while(n1<n)
if (n1 % 2 == 0)
{
    Console.Write($"{n1} ");
    n1 = n1 +1;
}
else 
{
    n1 = n1 +1;
}
