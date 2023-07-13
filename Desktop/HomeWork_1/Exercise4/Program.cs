// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите перовое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine());
if (numberA > numberB & numberA > numberC)
{
    Console.WriteLine($"Число {numberA} является максимальным из трёх чисел");
}
else
{
    if (numberB > numberA & numberB > numberC)
    {
        Console.WriteLine($"Число {numberB} является максимальным из трёх чисел");
    }
    else
    {
        if (numberC > numberA & numberC > numberB)
        {
            Console.WriteLine($"Число {numberC} является максимальным из трёх чисел");
        }
    }
}