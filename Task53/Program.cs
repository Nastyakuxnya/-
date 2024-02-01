// Задача 53: 
// Задайте двумерный массив. 
// Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

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

void ReplaseFirtsLastRows(int[,] matrix)
{
    int firstRow = 0;
    int lastRow = matrix.GetLength(0) - 1;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[firstRow, j];
        matrix[firstRow, j] = matrix[lastRow, j];
        matrix[lastRow, j] = temp;
    }   
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 8);
PrintMatrix(array2d);

Console.WriteLine();
ReplaseFirtsLastRows(array2d);

PrintMatrix(array2d);