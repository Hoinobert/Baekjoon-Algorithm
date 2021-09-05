using System;

class Program
{
    static void Main(string[] args)
    {
        string strInput = Console.ReadLine();  
        string[] splitStr = strInput.Split();

        Console.WriteLine(int.Parse(splitStr[0]) + int.Parse(splitStr[1]));
        Console.WriteLine(int.Parse(splitStr[0]) - int.Parse(splitStr[1]));
        Console.WriteLine(int.Parse(splitStr[0]) * int.Parse(splitStr[1]));
        Console.WriteLine(int.Parse(splitStr[0]) / int.Parse(splitStr[1]));
        Console.WriteLine(int.Parse(splitStr[0]) % int.Parse(splitStr[1]));
    }
}