// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);// 99 + 1 = 100
Console.WriteLine($"Случайное число из диапозона 10-99 -> {number}");
//int firstDigit = number / 10; // 78 / 10 = 7.8
//int secondDigit= number % 10; // 78 = 70 + 8
//if (firstDigit > secondDigit) Console.WriteLine($"Максимальная цифра числа -> {firstDigit}");
// else Console.WriteLine($"Максимальная цифра числа -> {secondDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Максимальная цифра числа -> {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = number / 10; 
    int secondDigit= number % 10;
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}
