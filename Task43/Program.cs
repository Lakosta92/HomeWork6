// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double Input (string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}

double k1 = 0;
double b1 = 0;
double k2 = 0;
double b2 = 0;

k1 = Input("Введите значение k1: ");
b1 = Input("Введите значение b1: ");
k2 = Input("Введите значение k2: ");
b2 = Input("Введите значение b2: ");

if (k1==k2)
{
    Input("Прямые парралельны");
}

else 
{

double x = (b1-b2)/(k2-k1);
double y = k1* x +b1;

Console.WriteLine($"x={x}; y={y}");
}
