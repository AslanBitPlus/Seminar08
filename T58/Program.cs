// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write($"{array[i, j], 2} ");
        }
        Console.WriteLine("|");
    }
}

// Умножение двух матриц
int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,]arr = new int[array1.GetLength(0), array2.GetLength(1)];
    

    for (int i = 0; i < array1.GetLength(0); i ++)
    {
        for (int n = 0; n < arr.GetLength(1); n ++)
        {
            for (int j = 0; j < array1.GetLength(1); j ++)
            {            
                arr[i, n] += array1[i, j] * array2[j, n];
                // Console.Write($"i={i}, j={j}, n={n}, arr={array1[i, j] * array2[j, n]}");
            }
        }
    }
    return arr;
}


// =======================
int[,] rndMatrix1 = CreateMatrixRndInt(2, 3, 1, 5);
Console.WriteLine("Матрица A");
PrintIntMatrix(rndMatrix1);

Console.WriteLine();
int[,] rndMatrix2 = CreateMatrixRndInt(3, 2, 1, 3);
Console.WriteLine("Матрица B");
PrintIntMatrix(rndMatrix2);

Console.WriteLine();
if (rndMatrix1.GetLength(0) == rndMatrix2.GetLength(1))
{
    Console.WriteLine("Матрица C = A x B");
    int[,] multiplicMatrix = MultiplicationMatrix(rndMatrix1, rndMatrix2);
    PrintIntMatrix(multiplicMatrix);
}
else 
{
    Console.WriteLine("Умножить матрицу A на B НЕвозможно!");
}


