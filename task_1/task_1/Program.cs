using System;
class Program
{
    static int CountJewels(string J, string S)
    {
        int count = 0;
        foreach (char c in S)
        {
            if (J.Contains(c))
            {
                count++;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку J (драгоценности):");
        string J = Console.ReadLine();

        Console.WriteLine("Введите строку S (камни):");
        string S = Console.ReadLine();

        int result = CountJewels(J, S);
        Console.WriteLine($"Вывод: {result}");
    }
}