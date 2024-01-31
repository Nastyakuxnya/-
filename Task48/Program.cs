// Задача 48. 
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// Amn = m+n. 
// Выведите полученный массив на экран.
//   m = 3, n = 4.

int[,] CreateMatrixSunIndexes(int rows, int columbs) // добавляем колличество рядом и колличество колонок /столбцов
{
    int[,] matrix = new int[rows, columbs];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
    {
       Console.Write($"{matrix[i, j], 4}"); 
    }  
     Console.WriteLine("]"); 
    } 
}

int[,] array2d = CreateMatrixSunIndexes(3, 4);
PrintMatrix(array2d);