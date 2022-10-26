/* Напишите программу, которая переведет одномерный массив (последний элемент
будет на первом месте, а первый - на последнем)
[1 2 3 4 5] -> [5 4 3 2 1]
*/
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }   
    Console.WriteLine("\n");
    
}

    int[] IntArray(int dimension)
    {
        int[] arr = new int[dimension];
        Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 10);
        }
        return arr;
    }


int GetDimensionFromConsole()
{
    Console.WriteLine("Введите размерность массива");
    int dimension = int.Parse(Console.ReadLine() ?? "");
    return dimension;
}

int[] ArrayReserve(int[] arr)
{
int[] resultArray = new int[arr.Length];
int count = 0;
for (int i = resultArray.Length - 1; i >= 0; i--)
{
    resultArray[count] = arr[i];
    count++;
}
return resultArray;
}

int dimension = GetDimensionFromConsole();
int[] startArray = IntArray(dimension);
Console.WriteLine("Изначальный массив: ");
PrintArray(startArray);

int[] resultArray = ArrayReserve(startArray);
Console.WriteLine("Перевернутый массив");
PrintArray(resultArray);

