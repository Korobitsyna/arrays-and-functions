// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
// 78 -> 8

// получение рандомного числа от minValu до maxValue

int GetNumber(int minValue, int maxValue)

{
    Random rnd = new Random(); // генерирует случайное число
    int result = rnd.Next(minValue, maxValue); // число от 10 до 99
    return result;
    }

    // получение максимальной цифры числа
    int GetMaxDigitOfNumber(int number)
    {
        int firstDigit = number/10; // 95/10=9,5 -> 9
        int secondDigit = number % 10; // 95/10=5
        if(firstDigit > 2)
        return firstDigit;
        else 
        return secondDigit;
    }

    int number = GetNumber(10, 100);
    int maxDigit = GetMaxDigitOfNumber(number);

    Console.WriteLine($"Максимальная цифра числа {number}: {maxDigit}");