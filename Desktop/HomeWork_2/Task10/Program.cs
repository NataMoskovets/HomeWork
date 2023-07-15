// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine ("Введите трёхзначное число: ");
int num = int.Parse (Console.ReadLine ());
int num1 = num % 100;
int num2 = num % 10;
int result = (num1 - num2) / 10;
Console.WriteLine ($"{num} -> {result}");

