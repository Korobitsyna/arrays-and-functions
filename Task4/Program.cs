// Напишите программу, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23.
// 14 - > нет
// 161 -> да

void GetNumber (int number)
{
    int result = number % 7; 
    int result1 = number % 23;
    if (result == 0 & result1 == 0)
        Console.WriteLine($"{number} -> да");
        else
         Console.WriteLine($"{number} -> нет");

}
GetNumber(14);