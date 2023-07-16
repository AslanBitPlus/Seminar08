// Задайте двумерный массив из целых чиселю
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых рассположен наименьший элемент
// массива.

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
int[,] ChangeMatrix(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    int min = array[0,0];
    // Находим минимальныйэлемент и ее позицию первого вхождения. 
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++) 
        {
            if (array[i, j] < min) 
            {
                min = array[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Минимальный элемент {min} в позиции [{minRow}, {minColumn}]");

    int[,] arr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        if (i != minRow)
        { 
            n = 0;
            for (int j = 0; j < array.GetLength(1); j ++)
            {
                if (j != minColumn)
                {
                    arr[m, n] = array[i, j];
                    n ++;
                }
                
            }
            m ++;
        }
    }
    return arr;
}

// =======================
int[,] rndMatrix = CreateMatrixRndInt(3, 3, -9, 18);
PrintIntMatrix(rndMatrix);

int[,]chMatr = ChangeMatrix(rndMatrix);

Console.WriteLine();
PrintIntMatrix(chMatr);
