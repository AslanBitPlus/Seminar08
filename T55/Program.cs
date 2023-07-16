// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцыю В случаеБ если
// это невозможно, программа должна вывести сообщение для
// пользователя

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


// Меняем строки на столбцы
void SwapRowsToColumnsMatrix1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < i; j ++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp; 
        }
        
    } 
}

// =======================
int[,] rndMatrix = CreateMatrixRndInt(3, 3, -9, 9);
PrintIntMatrix(rndMatrix);
Console.WriteLine();

if (rndMatrix.GetLength(0) != rndMatrix.GetLength(1))
    Console.WriteLine("В массиве невозможно поменять строки на столбцы!");
else
{
    SwapRowsToColumnsMatrix1(rndMatrix);
    PrintIntMatrix(rndMatrix);
}




