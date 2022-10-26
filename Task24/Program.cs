/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int GetNumberfromConsole(string message)
{
Console.WriteLine(message);
int number = int.Parse(Console.ReadLine() ?? "");
return number;
}

int b1 = GetNumberfromConsole("Введите b1");
int k1 = GetNumberfromConsole("Введите k1");
int b2 = GetNumberfromConsole("Введите b2");
int k2 = GetNumberfromConsole("Введите k2");

double coordinateX = 0;
double coordinateY = 0;
if(b1==b2 && k1==k2)
{
    Console.WriteLine("Прямые совпадают");
}
else if(k1==k2)
     Console.WriteLine("Прямые параллельны");
     else 
     {
     coordinateX = (double)(b2-b1)/(k2-k1);
      coordinateY = (double)(b1*k2-b2*k1)/(k2-k1);
      Console.WriteLine($"Точка пересечения двух прямых с координатами: {coordinateX}; {coordinateY}");
}