/* Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9;9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 20, сумма отрицательных равна -20.
*/

//Инициализация массива рандомными числами от -9 до 9 длиной length
int[] IntArray(int length )
{
int [] resultArray = new int[length];
Random rnd = new Random(); // ссылочный тип в управляемой куче
for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = rnd.Next(-9,10);
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

//получение суммы положительных чисел массиава
int GetSummOfPositive(int [] array)
{
    int summ = 0;
    for (int i =0; i < array.Length; i++)
    {
        if(array[i] > 0)
        summ += array[i];
    }
    return summ;
}
//получение суммы отрицательных чисел массиава
int GetSummOfNegative(int [] array)
{
    int summ = 0;
    for (int i =0; i < array.Length; i++)
    {
        if(array[i] < 0)
        summ += array[i];
    }
    return summ;
}
//первое значение положительная сумма, второе значение отрицательная
(int, int) GetSumms(int [] array)
{
    int positiveSum = 0;
    int negativeSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        negativeSum += array[i];
        else
        positiveSum += array[i];
    }
    return(positiveSum, negativeSum);
}


int length = GetNumber($"Введите размерность массива");
int[] arr = IntArray(length);
PrintArray(arr);

int positiveSum = GetSummOfPositive(arr);
int negativeSum = GetSummOfNegative(arr);

(int pos, int neg) = GetSumms(arr);

Console.WriteLine($"Сумма положительных: {positiveSum}, сумма отрицательных: {negativeSum}");
Console.WriteLine($"Сумма положительных: {pos}, сумма отрицательных: {neg}");
