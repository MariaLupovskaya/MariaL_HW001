// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите первое число");
String str1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
String str2 = Console.ReadLine();
Console.WriteLine("Введите третье число");
String str3 = Console.ReadLine();
int a = int.Parse(str1);
int b = int.Parse(str2);
int c = int.Parse(str3);

if(a > b && a > c)
{
    Console.WriteLine("Максимальное число = " + a);
}
if(b > a && b > c)
{
    Console.WriteLine("Максимальное число = " + b);
}
if(c > b && c > a)
{
    Console.WriteLine("Максимальное число = " + c);
}