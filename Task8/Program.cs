// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
String str = Console.ReadLine();
Console.WriteLine();
int N = int.Parse(str);
int a = 2;
while (a <= N)
{
    Console.WriteLine(a);
    a = a + 2;
}

