using System;

namespace baejoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0, -15}{1, -15}{2, -11}{3, -10}", "SHIP NAME", "CLASS", "DEPLOYMENT", "IN SERVICE");
            Console.WriteLine("{0, -15}{1, -15}{2, -11}{3, -10}", "N2 Bomber", "Heavy Fighter", "Limited", 21);
            Console.WriteLine("{0, -15}{1, -15}{2, -11}{3, -10}", "J-Type 327", "Light Combat", "Unlimited", 1);
            Console.WriteLine("{0, -15}{1, -15}{2, -11}{3, -10}", "NX Cruiser", "Medium Fighter", "Limited", 18);
            Console.WriteLine("{0, -15}{1, -15}{2, -11}{3, -10}", "N1 Starfighter", "Medium Fighter", "Unlimited", 25);
            Console.WriteLine("{0, -15}{1, -15}{2, -11}{3, -10}", "Royal Cruiser", "Light Combat", "Limited", 4);
        }
    }
}
