//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//Тело программы

Console.WriteLine("Введите значения для первой прямой: ");
Console.Write("k1 = ");
double k1 = InputInt();
Console.Write("b1 = ");
double b1 = InputInt();

Console.WriteLine("Введите значения для второй прямой: ");
Console.Write("k2 = ");
double k2 = InputInt();
Console.Write("b2 = ");
double b2 = InputInt();

double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Полученные координаты: ({x},{y})");
Console.WriteLine($"Проверка: {y} = {k2} * {x} + {b2}");


//методы

int InputInt()
{
    bool isParse = int.TryParse(Console.ReadLine(), out int number);

    if(isParse)
    {
        return number;
    }
    else
    {
        throw new ArgumentException("Введено некорректое значение!");
    }
}