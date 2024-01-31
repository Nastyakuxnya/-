// Задача 46.
// Задайте двумерный массив m x n, заполненный случайными числами.
// m=3, n=4.

//       0   1  2    3
// 0     1   4  8    19
// 1     5  -2  33  -2
// 2     77  3   8   1 

int[,] CreateMatrixRndInt(int rows, int columbs, int min, int max) // добавляем колличество рядом и колличество колонок /столбцов
{
    int[,] matrix = new int[rows, columbs];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max +1);
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

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);