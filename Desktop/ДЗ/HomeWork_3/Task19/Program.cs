// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write ("Введите пятизначное число: ");

string num = Console.ReadLine();
char [] arr = num.ToCharArray();
Array.Reverse(arr);
string num2 = new String (arr);

if (num == num2)
{
    Console.WriteLine ($"Число {num} -> да, является палиндромом");
}
else Console.WriteLine ($"Число {num} -> нет, не является полиндромом");

int GetInfo (string message)

{
    Console.Write (message);
    int num = Convert.ToInt32 (Console.ReadLine ());
    return num;
} 


