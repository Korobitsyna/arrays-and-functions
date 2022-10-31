/* Задайте двумерный массив размером m*n, каждый элемент находится по формуле
a(m,n) = m+n
выведите полученный массив на экран
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

int[,] CreatArray (int m, int n)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = i + j;
        }
    }
    return array;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] arrayResult = CreatArray(6, 8);
PrintMatrix(arrayResult);

