/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int GetNumb(string message)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;            
        else    
            Console.WriteLine("Было введено не число. Введите число");
    }
    return result;
}

void GetCube (int number)
{  
    Console.Write ($"{number} -> ");
    for (int i = 1; i <= number; i++)
    {    
        double cube = Math.Pow(i,3);
        Console.Write($"{cube}, ");
    }
}

int numb = GetNumb("Введите число : ");
GetCube(numb);