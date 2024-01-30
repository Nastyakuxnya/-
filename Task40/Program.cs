// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первую сторону треугольника");
int firstSide = int.Parse(Console.ReadLine());

Console.WriteLine("Введите вторую сторону треугольника");
int secondSide = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третью сторону треугольника");
int thirdSide = int.Parse(Console.ReadLine());

bool isTriangle = IsTriangleExists(firstSide, secondSide, thirdSide);

Console.WriteLine(isTriangle ? "Треугольник сущуствует" : "Треугольник не существует");

bool IsTriangleExists(int a, int b, int c)

// {
//     if (a < b + c && b < a + c && c < b + a)
//         return true;
//     return false;
// }
// это более расписанный вариант, проще будет так 
 {
    return a < b + c && b < a + c && c < b + a;
 }