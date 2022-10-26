/* Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

int GetNumberfromConsole(string message)
{
Console.WriteLine(message);
int number = int.Parse(Console.ReadLine() ?? "");
return number;
}

int numFirst = GetNumberfromConsole("Введите первое число");
int numSecond = GetNumberfromConsole("Введите второе число");
int numThird = GetNumberfromConsole("Введите третье число");

if(numFirst < numSecond + numThird && numSecond < numFirst + numThird && numThird < numFirst + numSecond)
{
   Console.WriteLine($"Каждая сторона треугольника меньше суммы двух других сторон");
}
else
{
    Console.WriteLine($"Трегуольник не может существовать");
}
