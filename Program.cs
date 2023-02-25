// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

bool inWork = true;

while (inWork)
{
    Console.Write("Выбери задачу ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1:
                {
                    Task_1();

                    break;
                }
            case 2:
                {
                    Task_2();
                    break;
                }
            case 3:
                {
                    Task_3();
                    break;
                }
            case -1: inWork = false; break;
        }
    }
}



void Task_1()
{
    EnterNumber(ReadInt("Number"));
}

void Task_2()
{
    Console.WriteLine($"sum = {SumNumbersFromMToN(ReadInt("M"), ReadInt("N"))}");
}

void Task_3()
{
    Console.WriteLine($"функция Акермана = {AckermanFunc(ReadInt("M"), ReadInt("N"))}");
}

int ReadInt(string argumrntName)
{
    Console.Write($"Input {argumrntName}: ");

    int number = 0;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number");
    }
    return number;
}

void EnterNumber(int number)
{
    if (number > 1)
    {
        Console.Write($"{number}, ");
        EnterNumber(number - 1);
    }
    else if ((number == 1))
    {
        Console.Write($"{number}");
    }
}

int SumNumbersFromMToN(int m, int n)
{
    if (m <= n)
    {
        return m + SumNumbersFromMToN(m + 1, n);
    }
    return 0;
}

int AckermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 && m != 0)
    {
        return AckermanFunc(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
    }
    return AckermanFunc(m, n);
}