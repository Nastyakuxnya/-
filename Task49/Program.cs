// Задача 49. 
// Задайте двумерный массив.Найдите элементы, у которых оба индекса четные,
//и замените эти элементы на их квадраты. 

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

void ReplaceElemOnSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
             matrix[i,j] *= matrix[i,j];
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 8);
PrintMatrix(array2d);

Console.WriteLine();

ReplaceElemOnSquare(array2d);
PrintMatrix(array2d);