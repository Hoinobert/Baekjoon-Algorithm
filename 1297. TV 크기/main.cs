using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        int diagonal = int.Parse(input[0]);
        int heightRatio = int.Parse(input[1]);
        int widthRatio = int.Parse(input[2]);

        double x = Math.Sqrt((diagonal * diagonal) / (double)(heightRatio * heightRatio + widthRatio * widthRatio));
     
        Console.WriteLine($"{(int)(x * heightRatio)} {(int)(x * widthRatio)}");
    }    
}