Console.Clear();
Console. Write("ВВедите число для проверки: ");
int number = Convert.ToInt32(Console.ReadLine());
Console. Write("ВВедите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console. Write("ВВедите первое число: ");
int b = Convert.ToInt32(Console.ReadLine());
bool Count (int num, int a1, int b1)
{
    return num % a1 == 0 & num % b1 == 0;
}

bool result = Count (number, a, b);

if (result) Console.WriteLine($"{number} кратно {a} и {b}");
else Console.WriteLine($"{number} некратно {a} и {b}");