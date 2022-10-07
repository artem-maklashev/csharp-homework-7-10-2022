/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

int GetCoordinates(string message)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.Write($"{message} -> ");

        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Введите валидную координату!\n");
    }
    return result;
}

double TakeLength(int ax, int ay, int az, int bx, int by, int bz)
{
    double length = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2)+Math.Pow((bz - az),2));
    return length;
}

int ax = GetCoordinates("Введите координату Х точки А:");
int ay = GetCoordinates("Введите координату Y точки А:");
int az = GetCoordinates("Введите координату Z точки А:");
int bx = GetCoordinates("Введите координату Х точки B:");
int by = GetCoordinates("Введите координату Y точки B:");
int bz = GetCoordinates("Введите координату Z точки B:");


double length = TakeLength(ax, ay,az, bx, by,bz);
Console.WriteLine($"A ({ax},{ay},{az}); B ({bx},{by},{bz} -> {length}");