// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти");
string quarter = Console.ReadLine();

string coordinatesRange = GetCoordinates (quarter);
Console.WriteLine(coordinatesRange == null ? $"Oшибка ввода" : coordinatesRange); 

string GetCoordinates (string quarterNumber)
{
    if(quarter=="1") return "x > 0, y > 0";
    if(quarter=="2") return "x < 0, y > 0";
    if(quarter=="3") return "x < 0, y < 0";
    if(quarter=="4") return "x > 0, y < 0";
    return null;
}