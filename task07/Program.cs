Console.Clear();
Console.Write("ВВедите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num <1000) {
    num = num % 10;
    Console. Write(num);
}
else {
    Console.Write("Это число не трехзначное");
}