/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

int[] IntArray(int length)
{
    int[] resultArray = new int[length];
    Random rnd = new Random(); // ссылочный тип в управляемой куче
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(-10, 10);
    }
    return resultArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
// получение числа с консоли
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

// получение минимального числа
int Min(int[] array)
{
    int min = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
// получение максимального числа
int Max(int[] array)
{
    int max = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}


//первое значение мин, второе значение макс
(int, int) GetMinMax(int [] array)
{
    int minimum = array[0];
    int maximum = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < minimum)
        minimum = array[i];
         if(array[i] > maximum)
        maximum = array[i];
    }
    return(minimum, maximum);
}

int length = GetNumber($"Введите размерность массива");
int[] array = IntArray(length);
PrintArray(array);
int min = Min(array);
int max = Max(array);

(int minimum, int maximum) = GetMinMax(array);
Console.WriteLine($"Минимум={min}, Максимум={max}");
Console.WriteLine($"Минимум={minimum}, Максимум={maximum}");