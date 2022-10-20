/* Напишите программу, которая определяет присутствие заданного числа в массиве
*/

Console.WriteLine("Введите число от -9 до 9: ");
int num = int.Parse(Console.ReadLine());

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

// проверка наличия числа в массиве
void FindNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            Console.WriteLine($"{num} находится в массиве");
            return;
        }
    }
    Console.WriteLine($"{num} не находится в массиве");
}
int length = GetNumber($"Введите размерность массива");
int[] array = IntArray(length);
PrintArray(array);
FindNumber(array, num);
Console.WriteLine($" Замена чисел");
