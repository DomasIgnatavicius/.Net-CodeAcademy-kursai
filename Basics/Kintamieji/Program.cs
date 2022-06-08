using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveikieji kintamieji");
            // Sveiku skaiciu kintamieji

            byte mazasSkaicius = 2; // max dydis: 255 ISIMINTI REIKSMIU NEREIKIA
            short trumpasSkaicius = 3; // max dydis: 32767
            int skaicius = 3345; // max dydis 2147483647 , min dydis: -2147483648
            int maximalus = int.MaxValue; // kiekvienas kintamasis turi sau budingu veiksmu, pvz .MinValue arba string.Count
            long ilgasSkaicius = 34543565; // max: 9223372036854775807
        }

    }
}
