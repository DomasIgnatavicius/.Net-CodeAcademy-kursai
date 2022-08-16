using _03_Metodai.Domain.Models; // prisideda reference, tam kad Metodai galetu pasiekti Metodai.Domain
using _03_Metodai.Domain.Models._7_uzduotis;
using _03_Metodai.Domain.Models.OOP_Metodai;

namespace _03_Metodai
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            //KonstruktoriuIrAccessabilityKartojimas();

            //Uzduotis 4: Atnaujinti kiekvienai is klasiu aprasytu 1 uzduotyje atributus (kontrakta)
            //taip, kad atributu reiksmes galima butu skaityti is isores,
            //bet nustatyti reiksmes butu galima tik klases viduje. (Namas, salis, knyga)

            // Cia tiesiog visus setterius pasidaryti private, bet ne internal, nes internal pasiekiams visame projekte, o private tik klaseje

            //KartojimasUzduotis7();

            OOPMetoduTeorija();

        }

        private static void OOPMetoduTeorija()
        {
            var staciakampis1 = new Staciakampiscs(5,3);
            var plotas = staciakampis1.ApskaiciuotiPlota();
            Console.WriteLine(plotas); // 15

            Console.WriteLine($"Staciakampio ilgis pries metoda PkeistiIlgi(): {staciakampis1.ilgis}");
            staciakampis1.pakeistiIlgi(8);
            Console.WriteLine($"Staciakampio ilgis po metoda PkeistiIlgi(): {staciakampis1.ilgis}");

            Console.WriteLine();
            Console.WriteLine($"Staciakampio plotis pries metoda PkeistiIlgi(): {staciakampis1.plotis}");
            staciakampis1.pakeistiPloti(8);
            Console.WriteLine($"Staciakampio plotis po metoda PkeistiIlgi(): {staciakampis1.plotis}");

            Console.WriteLine();
            Console.WriteLine($"Plotas: {staciakampis1.ApskaiciuotiPlota()}");
        }

        private static void KartojimasUzduotis7()
        {
            /*
                        Uzduotis 7:
                        Sukurkite 5 klases – Studentas, Mokykla, Mokytojas, PazymiuKnygele, Pamoka ir juos sukomponuokite(Sudekite rysius tarp ju).
                        Kiekviena mokykla turi nuo 1 iki begalybes mokytoju.
                        Kiekvienas mokytojas turi nuo 1 iki begalybes studentu.
                        Kiekvienas studentas turi 1 pažymių knygelę.
                        Kiekviena pažymių knygelė turi nuo 1 iki begalybės pamokų, kurios turi buti saugomos su studentu pazymiais.
                        Pamoka turi tik pavadinimą ir nuo 1 iki begalybės priskirtų mokytojų.
                        Inicializuokite klases su duomenimis(turi buti maziausiai uzpildytos 2 mokyklos) ir sukurkite 3 metodus, kurie atspausdinkite ekrane(Šie metodai turetu priimti tik 1 objekta.Objektai gali buti skirtingi tarp metodu):       
                        Mokyklos pavadinima +Kiekviena mokytoja kartu su jo mokiniu vardais
                        (Savarankiskai)Kiekviena mokini kartu su kiekvieno is ju pazymiais
                        (Savarankiskai)Kiekvieno studento kiekvienos pamokos pazymiu vidurki
            */

            static void AtspausdintiMokykla(Mokykla mokykla)
            {
                Console.WriteLine(mokykla.Pavadinimas);
                foreach (var mokytojas in mokykla.Mokytojai)
                {
                    Console.WriteLine($"Mokytojas: {mokytojas.Vardas}");
                    foreach (var mokinys in mokytojas.Studentai)
                    {
                        Console.WriteLine($"Mokinio vardas: {mokinys.Vardas}");
                    }
                }
            }

            static void AtspaudintiMokiniuVidurkius(Mokykla mokykla)
            {
                foreach (var mokytojas in mokykla.Mokytojai)
                {
                    foreach (var mokinys in mokytojas.Studentai)
                    {
                        foreach (var pamoka in mokinys.PazymiuKnygele.Pamokos)
                        {
                            Console.WriteLine($"Mokinys: {mokinys.Vardas}\nPamoka: {pamoka} - {ApskaiciuotiVidurki(pamoka.Value)}\n");
                        }
                    }
                }
            }
            static double ApskaiciuotiVidurki(List<int> pazymiai)
            {
                var vidurkis = 0;
                foreach (var pazymys in pazymiai)
                {
                    vidurkis += pazymys;
                }
                vidurkis /= pazymiai.Count;
                return vidurkis;
            }
        }

        private static void KonstruktoriuIrAccessabilityKartojimas()
        {
            Console.WriteLine("Hello, OOP Metodai!");
            //var zmogus1 = new Zmogus(); INTERNAL KLASE
            var namas = new Namas(3, "Vilniaus g. 78");
            //namas.kambariuSkaicius = 4; negalime, nes setteris yra PRIVATE
            foreach (var namoGyventojoVardas in namas.zmoniuVardai)
            {
                Console.WriteLine(namoGyventojoVardas); // Cia labia smart, nes mes is Metodai prieinam prie klases Zmogus, kuri yra internal ir siaip negaletume prieiti
                                                        // Bet prieinam per public klase Namas, kuri jau gali pasiekti klase Zmogus, cia toks apzaidimas
            }
            Console.WriteLine(namas.kambariuSkaicius);
            //namas.yraDarzas = true; neveikia, yraDarzas INTERNAL
        }
    }
}