/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

void GetNumber(int num)
{
    string numericAsstring = num.ToString();
   
    if(numericAsstring.Length > 2)
    Console.WriteLine($" {numericAsstring} -> третья цифра: {numericAsstring[2]}");
    else
    Console.WriteLine($" {numericAsstring} -> третьей цифры нет");
}
GetNumber(155);