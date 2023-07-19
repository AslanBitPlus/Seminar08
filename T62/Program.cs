// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Создание спирального двумерного массива
int[,] CreatSpiralMatrix(int size)
{
    int[,] matrix = new int[size, size];

    int iStart = 0;
    int iEnd = matrix.GetLength(0) - 1;
    int jStart = 0;
    int jEnd = matrix.GetLength(1) - 1;
    int num = 1;
    
    
    for (int n = 0; n <= size; n ++)
    {
    
    // Right
    for (int j = jStart; j <= jEnd; j ++)
    {
        matrix[iStart, j] = num;
        num ++;
    }
    iStart ++; 
    // Down
    for (int i = iStart; i <= iEnd; i ++)
    {
        matrix[i, jEnd] = num;
        num ++;
    }
    jEnd --;
    // Left
    for (int j = jEnd; j >= jStart; j --)
    {
        matrix[iEnd, j] = num;
        num ++;
    }
    iEnd --;
    // Up
    for (int i = iEnd; i >= iStart; i --)
    {
        matrix[i, jStart] = num;
        num ++;
    }
    jStart ++;
    n ++;
    }
    //
    
    return matrix;
}

// Печать двумерного массива
void PrintIntMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write($"{array[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

// =======================
int[,] spiralMatrix = CreatSpiralMatrix(15);
PrintIntMatrix(spiralMatrix);