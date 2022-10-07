/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

(string yn, int number) GetPolyndrom(string message)
{
    int result = 0;
    bool isCorrect = false;
    Console.Clear();
    while (!isCorrect)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result.ToString().Length == 5)
        {
            isCorrect = true;
            string numStr = result.ToString();
            int lastSymbol = numStr.Length - 1;
            for (int i = 0; i < numStr.Length / 2; i++)
            {
                if (numStr[i] != numStr[lastSymbol])
                    return ("нет", result);
                lastSymbol -= 1;
            }
        }
        else
            Console.WriteLine("Было введено не число или число не пятизначное.\nПовторите ввод\n");
    }
    return ("да", result);
}

var polyndrom = GetPolyndrom("Введите пятизначное число: ");
Console.WriteLine($"{polyndrom.number} -> {polyndrom.yn}");
