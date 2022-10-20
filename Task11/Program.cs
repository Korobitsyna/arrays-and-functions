/* Напишите программу замена элементов массива: положительный отрицательным и наоборот
[-4, -8, 8, 2] -> [4, 8, -8, -2]  */

//Инициализация массива рандомными числами от -9 до 9 длиной length

int[] IntArray(int length)
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
void NumReplace (int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i]*(-1);
    }
}




int length = GetNumber($"Введите размерность массива");
int[] arr = IntArray(length);
PrintArray(arr);
NumReplace(arr);
Console.WriteLine($" Замена чисел");
PrintArray(arr);