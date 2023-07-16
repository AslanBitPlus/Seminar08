// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива

// Создание двумерного массива заполненного случайными числами
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
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
// Поменяем местами первую и последнюю строку массива 
void SwapRowsMatrix(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j ++)
    {
        int temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp; 
    } 
}

// =======================
int[,] rndMatrix = CreateMatrixRndInt(3, 5, -9, 9);
PrintIntMatrix(rndMatrix);
Console.WriteLine();
SwapRowsMatrix(rndMatrix);
PrintIntMatrix(rndMatrix);




