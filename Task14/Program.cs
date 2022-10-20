/* Найдите произведение пар чисел в одномерном массиве. Парой считается первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в одном массиве.
[1 2 3 4 5] -> 5 8 3 */

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

int[] ResultFunction(int[] array)
{
    int newArrayLength = (array.Length / 2);

    if (array.Length % 2 != 0)
    {
        newArrayLength += 1;
    }

    int[] result = new int[newArrayLength];
    for (int i = 0; i < newArrayLength; i++)
    {
        result[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 != 0)
    {
    result[newArrayLength-1] = array[newArrayLength-1];
    }
    return result;
}

int length = GetNumber($"Введите размерность массива");
int[] array = IntArray(length);
PrintArray(array);
int[] resultArray = ResultFunction(array);
PrintArray(resultArray);