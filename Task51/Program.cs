// Задача 51. 
// Задайте двумерный массив.Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1,1) и т. д.).


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

int SumElemDiagonale(int[,] matrix)
{
    int sumElem = 0;
    // int size = matrix.GetLength(0); // (1) Условия для оптимизации программы
    // if (size > matrix.GetLength(1)) size = matrix.GetLength(1); // (1) словия для оптимизации программы

    // for (int i = 0; i < size; i++) // (1) Условия для оптимизации программы
    
    for (int i = 0; i < matrix.GetLength(0) && i<matrix.GetLength(1); i++)
    {
        // for (int j = 0; j < matrix.GetLength(1); j++)
        // {
        //     if (i == j) sumDiagElem += matrix[i, j];
        // }

      sumElem += matrix[i, i];
    }
    return sumElem;
}


int[,] array2d = CreateMatrixRndInt(4, 3, 1, 8);
PrintMatrix(array2d);

Console.WriteLine();

int sumElem = SumElemDiagonale(array2d);
Console.WriteLine($"Сумма элементов главной диагонали = {sumElem}");