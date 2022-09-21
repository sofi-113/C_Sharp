Console.Clear();
Console. Write("Введите число четверти: ");
string num = Console. ReadLine();

string Quarter (string n)
{
    if ( n == "1" ) return "x > 0, y > 0";
    if ( n == "2" ) return "x < 0, y > 0";
    if ( n == "3" ) return "x < 0, y < 0";
    if ( n == "4" ) return "x > 0, y < 0";
    return "Введены некорректные данные";
}
string result = Quarter (num);
Console. WriteLine (result);