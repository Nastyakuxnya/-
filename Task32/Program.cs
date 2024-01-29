// Напишите программу замена элементов массива:
// положительные элементы замените на соответсвующие 
// отрицательные и наоборотю
// [-4, -8, 8, 2,] -> [4, 8, -8, -2]

int[] CreateArrayRndInt(int size, int min, int max) // Это называется сигнатура метода 
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1); // +1 потому что в методе Next интервал не включен
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void InverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);

Console.WriteLine("Массив после инверсии:");

InverseArray(array);
PrintArray(array);

