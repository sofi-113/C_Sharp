﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console. Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 10000 == number % 10 && number / 1000 %10 == number % 100 / 10)
{
    Console. Write($"Число {number} - палиндром");
}
else Console. Write($"Число {number} - не является палиндромом");
