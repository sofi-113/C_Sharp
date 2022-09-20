// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console. Write("ВВедите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number < 1000){
    int Count (int num)
    {
        int firstnum = num / 10; 
        int secondnum = firstnum % 10;
        return secondnum;
    }
    int result = Count (number);
    System.Console.WriteLine($"{number} -> {result}");
}
else Console.WriteLine("Число не трехзначное");