/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Write("Введите координату b1:");
double b1=Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату k1:");
double k1=Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату b2:");
double b2=Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату k2:");
double k2=Convert.ToDouble(Console.ReadLine());

double xIntersection = 0;
double yIntersection = 0;

if (b1!=b2 & k1==k2) Console.WriteLine("Прямые параллельны друг другу");
else
    if (b1==b2 & k1==k2) Console.WriteLine("Прямые совпадают");
    else 
    {
        xIntersection = (b2 - b1) / (k1 - k2);
        yIntersection = k1 * xIntersection + b1;
        Console.WriteLine($"Координаты точки пересечения прямых ({xIntersection}; {yIntersection})");
    }

