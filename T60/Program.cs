// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// Создание трехмерного массива заполненного неповторяющимися двузначными числами
int[,,] Create3dMatrixRndInt(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    int num = 10;
    for (int i = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            for (int k = 0; k < matrix.GetLength(2); k ++)
            {
                matrix[i, j, k] = num;
                num ++;
            }
        }
    }
    return matrix;
}

// Печать трехмерного массива
void PrintInt3dMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            for (int k = 0; k < array.GetLength(2); k ++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

// =======================
int[,,] rnd3dMatrix = Create3dMatrixRndInt(2, 3, 2);

PrintInt3dMatrix(rnd3dMatrix);

