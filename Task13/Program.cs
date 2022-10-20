/* Задайте одномерный массив из 123 случайных чисел. Найдите количество ээементов
массива, значения которых лежат в отрезке [10, 99].
Пример два массива из 5, а не 123 элементов.
[5, 18, 123, 6, 2] -> 1
[15, 18, 12, 6, 2] -> 3 */

int[] IntArray(int length)
{
    int[] resultArray = new int[length];
    Random rnd = new Random(); // ссылочный тип в управляемой куче
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(-100, 100);
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

int CheckValues(int[] array)
{
    int counter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
            counter++;
    }
    return counter;
}


int length = GetNumber($"Введите размерность массива");
int[] array = IntArray(length);
PrintArray(array);
int counter = CheckValues(array);
Console.WriteLine($"Значений в диапазоне [10,99] = {counter} ");
