/* Не  рекурсию, выведите первые N чисел ФИбоначчи. Первые два числа Фибоначчи: 0 и 1

Если N = 5 -> 0 1 1 2 3 
Если N = 3 -> 0 1 1 
Если N = 7 -> 0 1 1 2 3 5 8
*/
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}
int[] GetArray(int num)
{
    int[] array = new int[num];
    if (num == 0) 
    {
    array[0] = 0;
    return array;
    }
    array[0] = 0;
    array[1] = 1;
   
    for (int i = 2; i < num; i++)
    {
        array[0] = 0;
        array[1] = 1;
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}
void PrintArray(int[] arr)
{
   
    for (int i = 0; i < arr.Length; i++)
    {
      Console.Write($"{arr[i]} ");
    }
}
int numb = GetNumber($"Введите количество чисел: ");
int[] array = GetArray(numb);
PrintArray(array);