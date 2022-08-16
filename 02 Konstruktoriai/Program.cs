

using _02_Prieinamumo_Pavyzdziu_Klases;

namespace _02_Konstruktoriai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KonstruktoriuTeorija();

            //KonstruktoriuPavyzdziai();

            PrieinamumoPVZ();

        }

        private static void PrieinamumoPVZ()
        {
            var prieinamumoPavyzdys = new PrieinamumoPVZAccessabilitycs("Prieinamumas"); // kadangi turime konstruktoriu, kuris praso pavardes, galime irasyti reiksme IS ISORES, nors pavarde ir yra private
            prieinamumoPavyzdys.vardas = "Priejimas";
            // prieinamumoPavyzdys.pavarde neveikia, nes pavarde yra private, jos is isores nepasieksi

            Console.WriteLine(prieinamumoPavyzdys.Pavarde); // taip galima, nes Pavarde(is didziosios) yra property ir turi public getteri

            // prieinamumoPavyzdys.Pavarde = "NaujasPrieinamumas"; taip neveikia, nes setteris yra private

            var prieinamumoPavyzdysIsKitoProjekti = new PrieinamumoPavyzdineKlase("Pavarde");
        }

        private static void KonstruktoriuPavyzdziai()
        {
            // Trys skirtingi konstruktoriai:
            // 1) Iraso defaultines reiksmes
            // 2) Pats irasai reiksmes
            // 3) Nukopijuoja viena obijekta i nauja obijekta(pats pasirenki kokias dalis kopijuoti)


            // 1)
            var zmogus = new Zmogus();

            // 2)
            var zmogus2 = new Zmogus("Laurynas", "Povilaitis", 1991, "vyras");
            Console.WriteLine(zmogus2.Vardas);

            // 3)
            // dublikuoja i nauja obijekta, pvz kuri zmogus3 ir i arguentus irasai zmogus2, tai sukurs nauja obijekta su zmogus2 vardu pavarde gimimoData ir lytimi
            var zmogus3 = new Zmogus(zmogus2);
        }

        private static void KonstruktoriuTeorija()
        {
            // PIRMAS budas
            var klientas1 = new Customer();
            klientas1.vardas = "Jonas";
            Console.WriteLine(klientas1.vardas); // Jonas

            // ANTRS budas
            Customer klientas2 = new Customer
            {
                vardas = "Ieva"
            };
            Console.WriteLine(klientas2.vardas); // Ieva

            // TRECIAS budas (su konstruktorium KLASEJE)
            var klientas3 = new Customer();
            Console.WriteLine(klientas3.vardas); // Stiurtas, nes klaseje pasidarem konstruktoriu ir yra stiurtas by default

            var klientas4 = new Customer("Aiste");
            Console.WriteLine(klientas4.vardas); // Aiste
        }
    }
}