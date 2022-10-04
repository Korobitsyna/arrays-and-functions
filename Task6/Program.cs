// Проверка на "дурака"

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        isCorrect = int.TryParse(Console.ReadLine(), out result);

        if(!isCorrect)
        Console.WriteLine("Ввели не число, введите корректное число");

        Console.WriteLine();
    }

    return result;
}
int number = GetNumber("Введите число");