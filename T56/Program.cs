// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

// Вычисляем суммы строк двумерного массива 
// и записываем в одномерный массив
int MinSumRowsMatrix(int[,] array)
{
    // Создаем массив для сумм строк
    int[] arr = new int[array.GetLength(1)];
    
    int sumRows = 0;
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        // Вычисляем сумму строки
        sumRows = 0;
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            sumRows += array[i, j];
        }
        arr[i] = sumRows;
    }
    //
    int minSumIndex = 0;
    int minSum = arr[0];
    for (int i = 0; i < arr.Length; i ++)
    {
        if (arr[i] < minSum)
        {
            minSum = arr[i];
            minSumIndex = i;
        }
    }
    return minSumIndex;
}

// =======================
int[,] rndMatrix = CreateMatrixRndInt(3, 3, 1, 9);
PrintIntMatrix(rndMatrix);

int minSumRows = MinSumRowsMatrix(rndMatrix);
Console.WriteLine();

Console.WriteLine($"Строка с минимальной суммой элементов: {minSumRows + 1} строка");
