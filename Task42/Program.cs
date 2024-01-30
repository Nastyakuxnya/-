// Задача 42: 
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

Console.Write("Введите десятичное число: ");
int number = int.Parse(Console.ReadLine());

int result = DecToBinnary(number);
Console.WriteLine($"Число в двоичном представлении = {result}");


int DecToBinnary(int number)
{
    int numResult = 0;
    int decimalBase = 1;
    while (number > 0)
    {
        numResult += number % 2 * decimalBase;
        number /= 2;
        decimalBase *= 10;
    }
    return numResult;

}


// Console.WriteLine($"Число в двоичном представлении = {DecToBinnaryStr(number)}");

// string DecToBinnaryStr(int num)
// {
//     string numResult = string.Empty;
//     while (num > 0)
//     {
//         numResult = num % 2 + numResult;
//         num /= 2;
//     }
//     return numResult;

// }