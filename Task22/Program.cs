/* Напишите программу, которая будет создавать копию заданного массива с помощью пулеметного копирования.
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

int[] CoppyArray(int[]arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;

}

int length = GetDimensionFromConsole();
int[] array = IntArray(length);
PrintArray(array);
Console.WriteLine();
int[] cloneArray = CoppyArray(array);
PrintArray(cloneArray);