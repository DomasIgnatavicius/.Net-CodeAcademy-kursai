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

            Console.WriteLine("isvedimas " + "vienoje " + "eiluteje"); // konkatinacija, naudoja daug atminties
            Console.WriteLine("{0} {1} {2}", "isvedimas", "vienoje", "eiluteje"); // kompozicija
            Console.WriteLine($"{"isvedimas"} vienoje {"eiluteje"}"); // interpoliacija, skaitomiausias, kencia performance

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("tekstas idedamas i \"kabutes\""); // \ yra escape simbolis
            Console.WriteLine("tekstas bus perkeltas i nauja eilute \nDABAR");
            Console.WriteLine("dideli \ttarpai \ttarp \tzodziu");
        }

    }
}
