﻿// Напишите программу, которая будет принимать на вход 2 числа и выводить является ли второе число кратным первому, если число 2 не кратно числу 1, то программа будет выводить остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16,4  -> кратно

void CompareNumb(int num1, int num2)
{
    int num3 = num2 % num1;
if (num3 == 0)
    Console.WriteLine($"{num1}. {num2}. Кратно");
else
    Console.WriteLine($"{num1}. {num2}. остаток {num3} некратно");
}
CompareNumb(5, 34);
