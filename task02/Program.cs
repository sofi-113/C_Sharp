﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console. Write("ВВедите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console. Write("ВВедите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2) {
    Console.Write($"Число {num1} больше, число {num2} меньше");
}
else {
    Console.Write($"Число {num2} больше, число {num1} меньше");
}