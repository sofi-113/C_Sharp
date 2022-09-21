Console.Clear();
Console. Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console. Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console. Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console. Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance (int xc1, int yc1, int xc2, int yc2)
{
    double dist = (xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1);
    return Math.Round(Math.Sqrt (dist), 2, MidpointRounding.ToZero);
}

Console. WriteLine (Distance(x1, y1, x2, y2));