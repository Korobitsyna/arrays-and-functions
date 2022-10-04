/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */


Console.WriteLine("Введите трехзначное число");
string number = Console.ReadLine();
int num = int.Parse(number);
while (!int.TryParse(Console.ReadLine(), out num) || num > 999 || num < 100) ;

{
    string numericAsstring = num.ToString();
    int secondDigit = int.Parse(numericAsstring[1].ToString());
    Console.WriteLine($"Трехзначное: {num}, вторая цифра: {secondDigit}");
}
Console.ReadLine();