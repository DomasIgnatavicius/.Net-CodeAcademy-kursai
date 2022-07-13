namespace P011_Debuginimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uzduoti3();
        }

        //------------------------------------------------UZDUOTYS-------------------------------------------

        public static void Uzduoti1()
        {
            /*Paprašyti naudotojo įvesti taisyklingojo daugiakampio kraštių kiekį (n) ir kraštinės ilgį (b)., 
               metodo parinkimui naudoti switch expression
               1. Kai įvestas trikampis, 
               - paprašyti įvesti aukšį h
               - A=1/2bh
               2. Kai įvestas keturkampis,
               - A=b*b
               3. Kai įvestas penkiakampis, šešiakampis ir t.t.,
               - paprašyti įvesti statmenį r
               - A=n/2 * b * r
               4. išvesti betkokio poligono vidinių kampų sumą
               - 180 * (n - 2)
              N.B! atkreipkite dėmesį į metodų testuojamumą. 
                visi atvejai 1,2,3 ir 4 turi būti atskiruose metoduose ir metodai turi būti testuojami*/
            Console.WriteLine("Iveskite taisyklingojo daugiakampio krastiniu kieki: ");
            var krastiniuKiekis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite krastines ilgi: ");
            var krastinesIlgis = Convert.ToInt32(Console.ReadLine());
            int aukstis = 0;
            int statmuo = 0;
            if (krastiniuKiekis == 3)
            {
                Console.WriteLine("Iveskite trikampio aukksti");
                aukstis = Convert.ToInt32(Console.ReadLine());
            }
            if (krastiniuKiekis >4)
            {
                Console.WriteLine("Iveskite statmeni");
                statmuo = Convert.ToInt32(Console.ReadLine());
            }
            var plotas = PoligonoPlotas(krastinesIlgis, krastiniuKiekis, aukstis, statmuo);
            Console.WriteLine($"Daugiakampio plotas yra {plotas}");
        }

        public static void Uzduoti2()
        {
            /* MATEMATIKA ---------------------------------------------------
             1. Sukurti metodus Suma, Atimtis, Daugyba, Dalyba.
             - Main metode paprašykite įvesti 2 skaičius
             - Kiekvienas matematinis veiksmas turi turėti savo metodą 
               metodas turi priimti 2 int tipo parametrus ir grąžinti atlikto veiksmo rezultatą.
             - Kiekvieno metodo darbo rezultatus atspausdinti Main metode.
             - Visų gautų rezultatų sumą atspausdinti Main metode.

            2. Skaičiuotuvas. Naudoti pirmos dalies matematinius metodus.
             - Main metode paprašykite įvesti 2 skaičius ir matematinį veiksmą
             - Metodas 'Skaiciuotuvas' turi priimti tris parametrus du skaičius (int tipo) ir veiksmą. 
             - Metodas 'Skaiciuotuvas' turi parinkti reikiamą matematinį metodą ir grąžinti rezultatą (naudoti switch)
             - parašyti testus
             - gautą rezultatą atspausdinti į ekraną Main metode.
             */

            Console.WriteLine("Iveskite du skaicius");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite matematini operatoriu");
            string veiksmas = Console.ReadLine();
            Console.WriteLine(Skaiciuotuvas(a,b,veiksmas));
        }

        public static void Uzduoti3()
        {
            /* 1.Naudodami method overloading sukurkite metodus Suma, Atimtis, Daugyba, Dalyba kurie priima du double tipo parametrus.
                (prieštai sukurtų metodų ištrinti negalima)
              2. Naudotojui įvedus skaičius nustatykite ar buvo įvestas skaičius su kableliu ar be ir duomenis nukreipkite reikiamiems metodams. 
                (Informaciją apie tai, koks metodas buvo panaudotas išveskite į debug konsolę)
              3. Matematinius metodus palildykite kėlimu kvadratu (^2) ir kėlimu kūbu ( ^3).
              4.Padarykite meniu, kur naudotojui leis pasirinkti koks matematinis veiksmas bus atliekamas 
                (gali parinkti arba veiksmą, arba veiksmo numerį meniu. Abiem atvejais bus atliekama matematinė operacija) 
                (Pasirinkimams panaudoti switch sakinį)
                  1) +
                  2) -
                  3) *
                  4) /
                  5) a^2
                  6) a^3*/

            Console.WriteLine("Iveskite du skaicius");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pasirinkite operatoriu:");
            Console.WriteLine("1) +");
            Console.WriteLine("2) -");
            Console.WriteLine("3) *");
            Console.WriteLine("4) /");
            Console.WriteLine("5) a^2");
            Console.WriteLine("6) a^3");
            var operatoriausNumeris = Console.ReadLine();
            string operatorius;

            //operatoriaus castinimas
            switch (operatoriausNumeris)
            {
                case "1":
                    operatorius = "+";
                    break;
                case "2":
                    operatorius = "-";
                    break;
                case "3":
                    operatorius = "*";
                    break;
                case "4":
                    operatorius = "/";
                    break;
                case "5":
                    operatorius = "^2";
                    break;
                case "6":
                    operatorius = "^3";
                    break;
                default:
                    operatorius = "+";
                    break;
            }

            if (arSveikiejiSkaiciai(a,b))
            {
                Console.WriteLine(Skaiciuotuvas(Convert.ToInt32(a), Convert.ToInt32(b), operatorius)); 
                Console.WriteLine("Buvo panaudotas int metodas");
            }
            else
            {
                Console.WriteLine(SkaiciuotuvaDouble(a, b, operatorius)); 
                Console.WriteLine("Buvo panaudotas double metodas");
            }
                
        }


        //---------------------------------------------UZDUOCIU METODAI--------------------------------------

        // UZDUOTIS 1
        public static double PoligonoPlotas(int krastinesIlgis, int krastiniuKiekis, int aukstis, int statmuo)
        {
            double plotas = krastiniuKiekis switch // switch expression, skirtas metodu pakvietimui
            {
                3 => trikampioPlotas(krastinesIlgis, aukstis),
                4 => keturkampioPlotas(krastinesIlgis),
                _ => DaugiakampioPlotas(krastinesIlgis, krastiniuKiekis, statmuo)
            };
            return plotas;
        }

        public static double trikampioPlotas(int krastinesIlgis, int aukstis) => 1d / 2 * krastinesIlgis* aukstis;


        public static double keturkampioPlotas(int krastinesIlgis) => Convert.ToDouble(krastinesIlgis * krastinesIlgis);

        public static double DaugiakampioPlotas(int krastinesIlgis, int krastiniuKiekis, int statmuo) => krastinesIlgis / 2d * krastiniuKiekis * statmuo;


        //UZDUOTIS 2

        public static int Suma(int a, int b) => a + b;
        public static int Atimtis(int a, int b) => a - b;
        public static int Daugyba(int a, int b) => a * b;
        public static double Kubu(int a, int b) => (double)a / b;
        public static int Kvadratu(int a) => a * a;
        public static int Kubu(int a) => a * a * a;
        public static double? Skaiciuotuvas(int a, int b, string veiksmas)
        {
            switch (veiksmas) //state machine
            {
                case "+":
                    return Suma(a, b);
                case "-":
                    return Atimtis(a, b);
                case "*":
                    return Daugyba(a, b);
                case "/":
                    return Dalyba(a, b);
                case "^2":
                    return Kvadratu(a);
                case "^3":
                    return Kubu(a);
                default:
                    return null;
            }
        }


        // UZDUOTIS 3

        public static double suma(double a, double b) => a + b;
        public static double Atimtis(double a, double b) => a - b;
        public static double Daugyba(double a, double b) => a * b;
        public static double Dalyba(double a, double b) => a / b;
        public static double Kvadratu(double a) => a * a;
        public static double Kubu(double a) => a * a * a;
        public static bool arSveikiejiSkaiciai(double a, double b)
        {
            if (a % 1 == 0 && b % 1 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        public static double SkaiciuotuvaDouble(double a, double b, string veiksmas)
        {
            var rezultatas = veiksmas switch
            {
            "+" => suma(a, b),
            "-" => Atimtis(a,b),
            "*" => Daugyba(a, b),
            "/" => Dalyba(a, b),
            "^2" => Kvadratu(a),
            "^3" => Kubu(a)
            };
            return rezultatas;
        }
    }
}