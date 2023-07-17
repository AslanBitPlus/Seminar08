// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// Находим минимальный элемент 
// и удаляем строку и столбец пересечения
void SortRowsMatrix(int[,] array)
{
    int[] arr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        // Переносим строку двумерного массива в одномерный
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            arr[j] = array[i, j];
        }
        // Сортировка по убыванию
        Array.Sort(arr);
        Array.Reverse(arr);
        // Перенос отсортированной строки в двумерный массив
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            array[i, j] = arr[j];
        }
    }
    //
}

// =======================
int[,] rndMatrix = CreateMatrixRndInt(3, 3, 1, 9);
PrintIntMatrix(rndMatrix);

SortRowsMatrix(rndMatrix);

Console.WriteLine();
PrintIntMatrix(rndMatrix);