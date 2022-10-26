/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

bool stop = false;
int number = 0;
int summ = 0;

while(!stop)
{
    Console.WriteLine("введите число");
    number = int.Parse(Console.ReadLine());
   
    if(number>0)
    summ++;

    Console.WriteLine("Продолжить вводить числа? y/n");
    string result = Console.ReadLine();
    if(result == "y")
        stop = false;
    else
        stop = true;
}
Console.WriteLine($"Количество чисел больше 0 - {summ}");