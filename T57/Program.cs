// Составить частотный словарь элементов двумерного массива
// Частотный словарь содержит информацию о том, сколько раз
// встречается элемент входныъ данных

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
// Печать одномерного массива
void PrintIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write($"{array[i]} ");
    }
}

// Переносим двумерный массив в одномерный
int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            arr[k] = matrix[i, j];
            k ++;
        }
    }
    return arr;
}

// 
void FrecuencyEducation(int[] array)
{
    int temp = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i ++)
    {
        if (array[i] == temp) count ++;
        else 
        {
            Console.WriteLine($"{temp} встречается {count} раз");
            temp = array[i];
            count = 1;
        }
        Console.WriteLine($"{temp} встречается {count} раз");
    }
}


// =======================
int[,] rndMatrix = CreateMatrixRndInt(3, 3, -9, 9);
PrintIntMatrix(rndMatrix);

Console.WriteLine();

int[] matToArr = MatrixToArray(rndMatrix);
Array.Sort(matToArr);
PrintIntArray(matToArr);

Console.WriteLine();
FrecuencyEducation(matToArr);