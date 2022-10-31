/* Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0), (1,1) и тд)
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма = 1+9+2
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[,] InitArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = rnd.Next(2, 10);
        }
    }
    return newArray;
}

int GetSumm(int[,] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                count+=matrix[i, j];
            }
        }

    }
    return count;
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
int row = GetNumber("Введите количество строк: ");
int column = GetNumber("Введите количество столбцов: ");
int[,] matrix = InitArray(row, column);
PrintMatrix(matrix);
Console.WriteLine($"Сумма всех чисел на главной диагонали равна {GetSumm(matrix)}");
