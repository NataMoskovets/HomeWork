﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result = -1;
if (num >= 100)
{
    while (num > 999)
    {
        num = num / 10;
    }
    result = num % 10;
    Console.WriteLine($"{num} -> {result}");
}

if (num < 100)
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
