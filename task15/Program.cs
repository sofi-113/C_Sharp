// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console. Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number <8){
    bool Day(int num)
    {
        return num == 6 || num == 7;
    }
    bool result = Day (number);   

    if (result) Console.WriteLine($"Выходной");
    else Console.WriteLine($"Не выходной");
}
else Console.WriteLine($"Введите число не соответстует запросу");