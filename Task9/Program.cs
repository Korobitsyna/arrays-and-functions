/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число от 1 до 7: ");
string number = Console.ReadLine();
int num = int.Parse(number); 
while (!int.TryParse(Console.ReadLine(), out num) || num > 7 || num < 1) ;
{
if (num == 6 || num == 7)
Console.WriteLine($"{num} -> Выходной");
else
Console.WriteLine($"{num} -> Рабочий");
}
