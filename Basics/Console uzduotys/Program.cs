using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // isveskite i ekrana savo varda
            //Console.WriteLine("Domas");

            //nuskaitykite is klaviaturos savo varda ir isveskite i ekrana
            //Console.WriteLine("     "  +  Console.ReadLine());

            //nuskaitykite is ekrano savo vardo pirma raide ir isveskite i ekrana jos ASCII koda
            //Console.WriteLine(" raides ASCII   " + (int)Console.ReadKey().KeyChar);

            //Nuskaitykite raide, nuskaitykite skaiciu, isveskite suma
            //Reikia atimti 48, nes kai paspaudi pvz 1, jis koduojamas skaiciumi 49. Kad vel turetume 1, turim atimti 48 
            //Console.WriteLine("Iveskite raide ir bet koki skaiciu");
            //Console.WriteLine("     rezultatas yra: {0}", (int)Console.ReadKey().KeyChar + (int)Console.ReadKey().KeyChar - 48);// <---- atimama 48, kad is ASCII simboliu kodo gautume skaiciu

            //isvesti i ekrana pasirinka punkta
            /*Console.WriteLine("(1) Pirkti");
            Console.WriteLine("(2) Parduoti");
            Console.WriteLine("(3) Likuciai");
            Console.WriteLine("Pasirinkimas yra: \"{0}\"", Console.ReadKey().KeyChar);
            Console.WriteLine($"Pasirinkimas yra: \"{Console.ReadKey().KeyChar}\"");
            Console.WriteLine("Pasirinkimas yra: \"" + Console.ReadKey().KeyChar + "\"");
            */

            //Zodzio LABAS kiekviena raide kitoj eilutej
            /*Console.WriteLine("L");
            Console.WriteLine("A");
            Console.WriteLine("B");
            Console.WriteLine("A");
            Console.WriteLine("S");
            //ARBA
            Console.WriteLine("L\nA\nB\nA\nS");
            */

            //LABAS su dideliais tarpain
            //Console.WriteLine("L\tA\tB\tA\tS");
            //LABAS kabutese
            //Console.WriteLine("\"LABAS\"");

            //isvesti zodi, nuskaityti ir isvesti antra zodzio raide
            //Console.WriteLine("Iveskite savo varda:");
            //Console.WriteLine($"Antra raide yra: {Console.ReadLine()[1]}");

            //ivesti varda, nuskaito ir isveda raidziu kieki
            //Console.WriteLine("Iveskite varda: ");
            //Console.WriteLine($"Zodyje yra {Console.ReadLine().Count()} raides");

            //Skaiciuotuvas, kuris atlieka veiksmus tik su vienazenkliais skaiciais
            Console.WriteLine();
        }

    }
}