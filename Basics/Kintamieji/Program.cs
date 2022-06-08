using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            saugomiduomenysCodeAcademy();
        }

        static void teorineDalis()
        {
            Console.WriteLine("Sveikieji kintamieji");
            // Sveiku skaiciu kintamieji

            byte mazasSkaicius = 2; // max dydis: 255 ISIMINTI REIKSMIU NEREIKIA
            short trumpasSkaicius = 3; // max dydis: 32767
            int skaicius = 3345; // max dydis 2147483647 , min dydis: -2147483648
            int maximalus = int.MaxValue; // kiekvienas kintamasis turi sau budingu veiksmu, pvz .MinValue arba string.Count
            long ilgasSkaicius = 34543565; // max: 9223372036854775807

            //Paprasti skaiciai negali buti null. STRING  GALI
            int? skaiciusKurisGaliButiNull;
            skaiciusKurisGaliButiNull = null;
            Console.WriteLine(skaiciusKurisGaliButiNull);

            // nesvarbu kur initializuoji kintamaji, svarbu kad pries naudojant jis butu initialized
            int skaicius2;
            skaicius2 = 2; // initialization
            Console.WriteLine(skaicius2);

            uint tikTeigiamasSkaicius = 2; // unsigned tipas, atsilaisvina atmintis, nes nureziam visas neigiamas reiksmes. Atmintyje vietos uzima tiek pat, tik galima irasyti dvigubai didesni teigiama skaiciu
            uint maxReiksme = uint.MaxValue; // 4294967295, dvigubai didesnis nei int, bet min reiksme yra 0








            Console.WriteLine("FLOATING POINT TYPER");
            // skaiciai su kableliu

            float maziausiasTrupmeninis = 8.5f; // reikai naudoti raideles, kad kompiliatorius zinotu kokio tipo bandom priskirti
            var trumpasVar = 8.5; // by default priskyre double, jei norim float, reikia prideti f raide
            decimal didziausiasTrupmeninis = 8.5m;
            // atmintyje kablelis nera saugomas, skaicius su kableliu yra saugomsa kaip matematine israiska pvz. 10*kazkas pakelta kazkuo ir panasiai

            //patogesni uzrasymai
            double avogadroSkaicius = 6.022e23; // 23 nuliai 6.022*10^23
            double digitSeparator = 522_1_000.000_001; // tiesiog kad lengviau skaitytusi skaicius, kompiliatorius i underscore nekreipia demesio








            Console.WriteLine("LOGINIAI KINTAMIEJI");
            // true false
            bool teisybe = true;
            bool neteisybe = false;
            bool? nullableBool = null;










            Console.WriteLine("CHAR KINTAMIEJI");
            // char kintamasis gali saugoti tik viena simboli
            char raide = 'a'; // naudojamos viengubos kabutes
            // issaugo atmintyje skaitmeni(ASCII)

            char.IsDigit(raide); // patikrina ar skaicius, grazina true arba false
            char.IsLetter(raide); // patikrina ar raide
            char.IsLetterOrDigit(raide); // patikrina ar raide ar skaicius, grazina true jeigu "raide" yra raide arba skacius, kitu atvejju false
            char.IsPunctuation(raide); // patikrina ar tai skyrybos zenkas(kablelis, taskas ir t.t)










            Console.WriteLine("DATE TYPE");
            // datos
            DateTime siandien = DateTime.Today;
            DateTime dabar = DateTime.Now;
            Console.WriteLine(dabar);








            Console.WriteLine("VAR KINATAMIEJI");
            //automatiskai priskiria tipa

            var nulis = 0; // int
            var automatinisLongas = 99999999999999999; // int64, kitaip tariant long
            var kazkoksTextas = "kazkoks tekstas"; // string
            var kazkokiaData = new DateTime(2022, 06, 08);









            KeyValuePair<int, string> raktasIrReiksme = new KeyValuePair<int, string>(10, "Laptop"); // saugo dvi reiksmes
            Console.WriteLine(raktasIrReiksme.Key); // 10
            Console.WriteLine(raktasIrReiksme.Value); // Laptop

            Tuple<int, int, string> tuplas = new Tuple<int, int, string>(20, 1500, "Laptop"); // saugo iki 7 reiksmiu
            Console.WriteLine(tuplas.Item1); // 20
            Console.WriteLine(tuplas.Item2); // 1500
            Console.WriteLine(tuplas.Item3); // Laptop
        }


        static void saugomiduomenysCodeAcademy()
        {
            string pavadinimas = "CodeAcademy";
            string kursoPavadinimas = ".NET kursai";
            int studentuSakicius = 18;
            DateTime siandienosData = DateTime.Today;
            Console.WriteLine(pavadinimas);
            Console.WriteLine(kursoPavadinimas);
            Console.WriteLine(studentuSakicius);
            Console.WriteLine(siandienosData);

            //PAPILDYTI PROGRAMĄ IR PRIDĖTI:
            //KURSO PRADŽIOS DATĄ
            //KURSO PABAIGOS DATĄ
            //Sužinoti skirtumą tarp pradžios ir dabartinės datos(dienomis)
            //VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ

            DateTime kursoPradziosData = new DateTime(2022,05,03);
            DateTime kursoPabaigosData = new DateTime(2023,01,30);
            var skirtumas = siandienosData - kursoPradziosData;
            Console.WriteLine(kursoPradziosData.ToString("D"));
            Console.WriteLine(kursoPabaigosData.ToString("D"));
            Console.WriteLine(skirtumas);


            //Sukurkite tris kintamuosius. tekstinio, sveiko skaitmens ir loginio tipo.
            //Parašykite programą kuri į konsolę visus aprašytus kintamuosius vienoje eilutėje atskiriant tarpu

            string name = "name";
            int age = 5;
            bool isBoy = true;
            Console.WriteLine($"{name} {age} {isBoy}");


            /*Sukurkite tris sveikojo skaitmens tipo kintamuosius.
            Parašykite programą kuri į konsolę visus aprašytus kintamuosius atskiriant tarpu
            -panaudokite konkatinacija
            - panaudokite kompoziciją
            -panaudokite interpociacija
            */

            int vienas = 1;
            int du = 2;
            int trys = 3;
            Console.WriteLine(vienas + " " + du + " " + trys);
            Console.WriteLine("{0} {1} {2}", vienas, du, trys);
            Console.WriteLine($"{vienas} {du} {trys}");
        }
    }
}
