Console.Clear();
int number = new Random().Next(100, 1000);
int MaxDigit(int num)
{
    int firstDigit = num / 100 * 10; 
    int secondDigit = num % 10;
    return firstDigit + secondDigit;
}
int result = MaxDigit (number);
System.Console.WriteLine($"{number} -> {result}");