// Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли первое число
//кратным второму. Если первое число не кратно
//второму, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

Console.Write("Введите первое число: ");
int fistingNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int reminder = IsMultipliciti (fistingNum, secondNum);
if(reminder == 0) Console.Write("кратно");
else Console.Write($"не кратно, остаток {reminder}");

int IsMultipliciti(int fistingNumber, int secondNumber)
{
    return fistingNumber % secondNumber;
}