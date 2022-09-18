Console.Clear();
// int Mondey = 1;
// int Tuesday = 2;
// int Wednesday = 3;
// int Thursday = 4;
// int Friday = 5;
// int Saturday = 6;
// int Sunday = 7;
Console. Write("ВВедите число от 1 до 7: ");
string day = Console.ReadLine();
if (day == "1") {
    Console.WriteLine("Понедельник");
}
else if (day == "2") {
    Console.WriteLine("Вторник");
}
else if (day == "3") {
    Console.WriteLine("Среда");
}
else if (day == "4") {
    Console.WriteLine("Четверг");
}
else if (day == "5") {
    Console.WriteLine("Пятница");
}
else if (day == "6") {
    Console.WriteLine("Суббота");
}
else if (day == "7") {
    Console.WriteLine("Вщскресенье");
}
else {
    Console. Write("Это число не является днем недели");
}