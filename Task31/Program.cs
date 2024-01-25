//задача 31, решение через один и два метода п
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положитеьных элементов массива.

// Например,  в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных чисел равна 29,
// сумма отрицательных чисел равна -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max +1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
   for (int i = 0; i < arr.Length; i++)
    {
      if(i < arr.Length -1)  Console.Write($"{arr[i]}, "); 
      else Console.Write($"{arr[i]}"); 
    }  
     Console.Write("]");  
}

int SumPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int SumNegatElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] SumPositivNegativeElem(int[] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            sumPositive += arr[i];
        }
        else
        {
            sumNegative += arr[i];
        }
    }
    return new int[]{ sumPositive, sumNegative};
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);

int sumPositiveElem = SumPositiveElem(array);
int sumNegatElem = SumNegatElem(array);
Console.WriteLine($"Сумма положительных эдементов = {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных эдементов = {sumNegatElem}");

int[] sumPositivNegativeElem = SumPositivNegativeElem(array);
Console.WriteLine($"Сумма положительных эдементов = {sumPositivNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных эдементов = {sumPositivNegativeElem[1]}");
