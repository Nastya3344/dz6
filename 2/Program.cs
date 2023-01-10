// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Кординаты точки пересечения по формулам:
// x = (b2 - b1) / (k1 - k2)
// y = k1 * (b2 - b1) / (k1 - k2) + b1

Console.WriteLine ("Пересечение прямых y = k1 * x + b1, y = k2 * x + b2");

// Создаем метод для ввода числа пользователем

double InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

double b1 = InputNum ($"Задайте b1: ");
double k1 = InputNum ($"Задайте k1: ");
double b2 = InputNum ($"Задайте b2: ");
double k2 = InputNum ($"Задайте k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;

Console.WriteLine ($"Точка пересечения прямых: ({x}, {y})");