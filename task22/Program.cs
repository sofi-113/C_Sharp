﻿Console.Clear();
Console. Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= n)
{
    Console. WriteLine ($"| {i} - {i * i,3} |");
    i++;
}
