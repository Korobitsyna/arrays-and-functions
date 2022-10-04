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



/*
reference (ссылочные) - string, class, list, arrays
value (значимые) - datetime, int, enum, long, double

стек и управляемая куча

стек - значимые значения

управляемая куча - ссылочные
*/