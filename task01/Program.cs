Console.Clear();
Console. Write("ВВедите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console. Write("ВВедите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num2 * num2;
if (square == num1) {
    Console.WriteLine($"Квадрат чилса {num2} = {num1}");
}
else {
    Console.WriteLine($"{num1} Не квадрат чилса {num2}");
}
