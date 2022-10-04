// Напишите программу, которая принимает на вход 2 числа и проверяет, является ли первое число квадратом другого.

void CompareNumb(int num1, int num2)
{
    int num3 = num2 * num2;
    int num4 = num1 * num1;
    if(num1 == num3 || num2 == num4)
     Console.WriteLine($"{num1}. {num2}. Является");
     else
     Console.WriteLine($"{num1}. {num2}. Не является");
}
CompareNumb(4, 16);
