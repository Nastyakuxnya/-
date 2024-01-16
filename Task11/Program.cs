// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

//ПЕРВЫЙ ВАРИАНТ РЕШЕНИЯ 

int number = new Random().Next(100, 1000);// 999 + 1 = 1000
Console.WriteLine($"Случайное число из диапозона 100-999 -> {number}");
int firstDigit = number / 100;
int thirdDigit = number % 10;
int rezultDigit = firstDigit * 10 + thirdDigit;

Console.WriteLine($"Ответ: {rezultDigit}");

//  ВТОРОЙ ВАРИАНТ РЕШЕНИЯ 

int rezult = RemoveSecondDigit (number);
Console.WriteLine($"Ответ: {rezult}");
int RemoveSecondDigit(int num)
{
    int firstDigit = num / 100;
int thirdDigit = num % 10;
int rezultDigit = firstDigit * 10 + thirdDigit;
return rezultDigit;
}