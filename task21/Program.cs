// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console. Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console. Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console. Write("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console. Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console. Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console. Write("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double Distance (int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    double dist = (xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1) + (zc2 - zc1) * (zc2 - zc1);
    return Math.Round(Math.Sqrt (dist), 2, MidpointRounding.ToZero);
}

Console. WriteLine (Distance(x1, y1, z1, x2, y2, z2));