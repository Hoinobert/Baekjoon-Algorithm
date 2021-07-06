using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= input; ++i)
        {
            sum += i;
        }

        Console.WriteLine(sum);
    }
}