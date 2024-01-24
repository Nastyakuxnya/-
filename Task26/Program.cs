// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int count = GetCountDigits(number);
Console.Write($"Колличество цифр в числе {number} = {count}");

int GetCountDigits(int num)
{
    if (num == 0) return 1;

    int counter = 0;
    while (num != 0) // != означает не равно 
    {
        num /= 10; // num = num / 10;
        counter++; // counter =  counter + 1;
    }
     return counter;
}