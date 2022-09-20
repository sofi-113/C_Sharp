Console.Clear();
Console. Write("ВВедите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console. Write("ВВедите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
bool Count (int num1, int num2)
{
    return num1*num1==num2 || num2*num2==num1;
}

bool result = Count (number1, number2);

if (result) Console.WriteLine($"да");
else Console.WriteLine($"нет");