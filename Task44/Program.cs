// Задача 44: 
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int[] Fibonacci(int num)
{
    int[] array = new int[num];
    //array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i -2];
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
   for (int i = 0; i < arr.Length; i++)
    {
      if(i < arr.Length -1)  Console.Write($"{arr[i]}, "); 
      else Console.Write($"{arr[i]}"); 
    }  
     Console.WriteLine("]");  
}

Console.WriteLine("Input size of array, more than 2: ");
int size = Convert.ToInt32(Console.ReadLine());

if (size<2)
{
    Console.WriteLine("Incorrect size.");
    return;
}

PrintArray(Fibonacci(size));