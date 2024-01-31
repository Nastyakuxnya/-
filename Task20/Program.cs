// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координаты точки А: ");
Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки В: ");
Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double dist = GetDistance(x1, y1, x2, y2);
double distRound = Math.Round(dist, 2, MidpointRounding.ToZero);
Console.Write("Расстояние между А и В: " + distRound);

double GetDistance(int a1, int a2, int b1, int 
b2)
{
    double firstCatet = b1 - a1;
    double secondCatet = b2 - a2;
    double distance = Math.Sqrt(firstCatet * firstCatet + secondCatet* secondCatet);
    return distance;
}