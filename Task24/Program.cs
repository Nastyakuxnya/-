// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.WriteLine("Введите  целое положительное число");
int number = int.Parse(Console.ReadLine());

int sumNumbers = SumNumbers (number);
Console.WriteLine($"Сумма чисел в диапазоне от 1 до {number} = {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum += i; // sum = sum + i;
    }
    return sum;
}