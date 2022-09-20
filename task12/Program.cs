Console.Clear();
Console. Write("ВВедите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console. Write("ВВедите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());


bool MaxDigit(int num1, int num2)
{
    return num1 % num2 == 0;
}

bool result = MaxDigit (number1, number2);

if (result) Console.WriteLine($"{number1} кратно {number2}");
else Console.WriteLine($"{number1} некратно {number2}, остаток от деления {number1 % number2}");