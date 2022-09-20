// Console.Clear();
// int number = new Random().Next(10, 100);
// int firstDigit = number/10; 
// int secondDigit = number%10;
// if (firstDigit > secondDigit) System.Console.WriteLine ($"Наибольшая цифра числа {number}: {firstDigit}");
// else Console.WriteLine ($"Наибольшая цифра числа {number}: {secondDigit}");
// if (firstDigit == secondDigit) Console.WriteLine ("Цифры равны");
// else
// { 
//     int max = firstDigit > secondDigit ? firstDigit : secondDigit;
//     Console.WriteLine ($"Наибольшая цифра числа {number} : {max}");
// }

// int max1 = Math.Max(8, 8);
Console.Clear();
int number = new Random().Next(10, 100);

int MaxDigit(int num)
{
    int firstDigit = num / 10; 
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int maxDigit = MaxDigit(number);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
Console.WriteLine ($"Наибольшая цифра числа {number} : {result}");

