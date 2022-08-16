namespace Object_Oriented_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var zmogus = new Zmogus();
            zmogus.Vardas = "Andrius";
            Console.WriteLine($"zmogus.Vardad: {zmogus.Vardas}");

            var zmogus2 = zmogus; // abu obhektai rodo i ta pati adresa, todel kai pakeiti viena, pvz zmogus2 i antana, pasikeicia abu obijektai
            Console.WriteLine($"zmogus2.Vardad: {zmogus2.Vardas}");

            Console.WriteLine();

            zmogus2.Vardas = "Antanas";
            Console.WriteLine($"zmogus.Vardad: {zmogus.Vardas}");
            Console.WriteLine($"zmogus2.Vardad: {zmogus2.Vardas}");

            Console.WriteLine();

            // Jeigu pakeisim zmogus5 varda, pasikeist ir 1 2 3 4 vardai
            var zmogus3 = zmogus;
            var zmogus4 = zmogus;
            var zmogus5 = zmogus;
            zmogus5.Vardas = "Ana";
            Console.WriteLine($"zmogus.Vardad: {zmogus.Vardas}");
            Console.WriteLine($"zmogus2.Vardad: {zmogus2.Vardas}");
            Console.WriteLine($"zmogus3.Vardad: {zmogus3.Vardas}");
            Console.WriteLine($"zmogus4.Vardad: {zmogus4.Vardas}");
            Console.WriteLine($"zmogus5.Vardad: {zmogus5.Vardas}");

            Console.WriteLine();

            // Jeigu yra new, tada kuriamas visikai naujas obijektas, jis neberodo i zmogus1, TA IR REISKIA ZODIS NEW
            var zmogus6 = new Zmogus();
            zmogus6.Vardas = "Nebe Ana";
            Console.WriteLine($"zmogus.Vardad: {zmogus.Vardas}");
            Console.WriteLine($"zmogus2.Vardad: {zmogus2.Vardas}");
            Console.WriteLine($"zmogus3.Vardad: {zmogus3.Vardas}");
            Console.WriteLine($"zmogus4.Vardad: {zmogus4.Vardas}");
            Console.WriteLine($"zmogus5.Vardad: {zmogus5.Vardas}");
            Console.WriteLine($"zmogus6.Vardad: {zmogus6.Vardas}");
        }

        class Zmogus
        {
            public string Vardas { get; set; }
            public string Pavarde { get; set; }
        }
    }
}

