// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1
/*
    {
        int N = 5; // Задайте значение N здесь

        PrintNumbers(N);

        Console.ReadLine();
    }

    static void PrintNumbers(int n)
    {
        if (n < 1)
            return;

        Console.Write(n);

        if (n > 1)
            Console.Write(", ");

        PrintNumbers(n - 1);
    }
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
    {
        int M = 4; // Задайте значение M здесь
        int N = 8; // Задайте значение N здесь

        int sum = CalculateSum(M, N);

        Console.WriteLine(sum);

        Console.ReadLine();
    }

    static int CalculateSum(int m, int n)
    {
        if (m > n)
            return 0;

        int sum = m + CalculateSum(m + 1, n);
        return sum;
    }
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
/*
    {
        int m = 2; // Задайте значение m здесь
        int n = 3; // Задайте значение n здесь

        int result = CalculateAckermann(m, n);

        Console.WriteLine("A({0}, {1}) = {2}", m, n, result);

        Console.ReadLine();
    }

    static int CalculateAckermann(int m, int n)
    {
        while (true)
        {
            if (m == 0)
                return n + 1;

            if (n == 0)
            {
                n = 1;
                m--;
                continue;
            }

            int temp = CalculateAckermann(m, n - 1);
            m--;
            n = temp;
        }
    }
*/