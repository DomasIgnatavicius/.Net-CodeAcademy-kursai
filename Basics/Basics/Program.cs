using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("isvedimas");
            Console.WriteLine("vienoje");
            Console.WriteLine("eiluteje");
            Console.WriteLine();
            Console.WriteLine("Tekstas kitoje eiluteje");
            Console.Write("tekstas");

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("isvedimas " + "vienoje " + "eiluteje"); // konkatinacija
            Console.WriteLine();
        }
    }
}