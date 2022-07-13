using System.Text;

namespace P012_Ciklai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uzduotis9DaugybosLentele();
        }

        //----------------UZDUOTYS------------------

        public static void uzduotis1ReadIntNumber()
        {
            /*Sukurti metodą ReadIntNumber, 
              kuris paprašo vartotojo įvesti sveikąjį skaičių ir tą skaičių grąžina.
              Jeigu vartotojas įveda blogą skaičių, tai programa turi informuoti, kad
              įvestas blogas skaičius ir prašyti įvesti vėl. Kol vartotojas
              neįveda tinkamo skaičiaus metodas turi vis prašyti įvesti.
              (Hint) -> Panaudoti int.TryParse metodą ir while ciklą.*/

            bool teisingasSk = false;
            int skaicius;
            while (!teisingasSk)
            {
                Console.WriteLine("Iveskite skaiciu");
                if(int.TryParse(Console.ReadLine(), out _))
                {
                    teisingasSk = true;
                }
                else
                    Console.WriteLine("Ivestas neteisingas skaicius");
            }
            Console.WriteLine("Teisingai!");
        }

        public static void uzduotis2IntToBinary()
        {
            Console.WriteLine("Iveskite sveikaji teigiama skaiciu:");
            int OGskaicius = Convert.ToInt32(Console.ReadLine());
            List<int> binary = new List<int>();
            int i = 0;
            int skaicius = OGskaicius;
            while(skaicius != 0)
            {

                binary.Add(skaicius%2);
                skaicius = skaicius/2;
                i++;

            }
            Console.WriteLine();
            binary.Reverse();
            
            Console.WriteLine($"{OGskaicius} --> {string.Join("", binary)}");
        }

        public static void uzduotis3KelimasLaipsniu()
        {
            Console.WriteLine("Iveskite skaicius, kuri norite kelti laipsniu:");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite laipni, kuriuo norite kelti skaiciu:");
            int laipsnis = Convert.ToInt32(Console.ReadLine());
            if(skaicius == 0 && laipsnis > 0)
            {
                Console.WriteLine("1");
            }
            else if (skaicius == 0 && laipsnis == 0)
            {
                Console.WriteLine("0");
            }
            else if (laipsnis == 1)
            {
                Console.WriteLine(skaicius);
            }
            else
            {
                int result = skaicius;
                for (int i  = 1; i < laipsnis; i++)
                {
                    result = result * skaicius;
                }
                Console.WriteLine(result);
            }

        }

        public static void uzduotis4SkaiciuTrikampis()
        {
            bool teisingasSk = false;
            int skaicius;
            while (!teisingasSk)
            {
                Console.WriteLine("Iveskite skaiciu nuo 1 iki 9");
                skaicius = Convert.ToInt32(Console.ReadLine());
                if (skaicius > 1 && skaicius < 9)
                {
                    Console.WriteLine();
                    teisingasSk = true;
                    string isvedimas = "";
                    for (int i = 0; i < skaicius; i++)
                    {
                        isvedimas += Convert.ToString(skaicius);
                        Console.WriteLine(isvedimas);
                    }
                }
            }
            
        }

        // STRING BUILDER - naudojamas tik cikluose, nes daug greitesnis ir naudoja daug maziau atminties, necikluose naudoti nera prasmes
        public static void uzduotis4SkaiciuTrikampisStringBuilder()
        {
            bool teisingasSk = false;
            int skaicius;
            while (!teisingasSk)
            {
                Console.WriteLine("Iveskite skaiciu nuo 1 iki 9");
                skaicius = Convert.ToInt32(Console.ReadLine());
                StringBuilder sb = new StringBuilder();
                if (skaicius > 1 && skaicius < 9)
                {
                    Console.WriteLine();
                    teisingasSk = true;
                    for (int i = 0; i < skaicius; i++)
                    {
                        sb.Append(skaicius);
                        Console.WriteLine(sb);
                    }
                }
            }

        }

        public static void uzduotis5SkaiciuPiramide()
        {
            bool teisingasSk = false;
            int skaicius;
            while (!teisingasSk)
            {
                Console.WriteLine("Iveskite skaiciu nuo 1 iki 9");
                skaicius = Convert.ToInt32(Console.ReadLine());
                StringBuilder sb = new StringBuilder();
                if (skaicius > 1 && skaicius < 9)
                {
                    Console.WriteLine();
                    teisingasSk = true;
                    for (int i = 0; i < skaicius*2; i++)
                    {
                        if(i < skaicius)
                        {
                            sb.Append(skaicius);
                            Console.WriteLine(sb);
                        }
                        else if(i > skaicius)
                        {
                            sb.Remove(sb.Length -1,1);
                            Console.WriteLine(sb);
                        }
                    }
                }
            }

        }

        public static void uzduotis6DidejanciuSkaiciuTrikampis()
        {
            bool teisingasSk = false;
            int skaicius;
            while (!teisingasSk)
            {
                Console.WriteLine("Iveskite skaiciu nuo 1 iki 9");
                skaicius = Convert.ToInt32(Console.ReadLine());
                StringBuilder sb = new StringBuilder();
                if (skaicius > 1 && skaicius < 9)
                {
                    Console.WriteLine();
                    teisingasSk = true;
                    for (int i = 1; i <= skaicius; i++)
                    {
                        for(int j = 0; j < i; j++)
                        {
                            sb.Append(i);
                            
                        }
                        Console.WriteLine(sb);
                        sb.Clear();
                    }
                }
            }

        }

        public static void uzduotis7DidejanciuSkaiciuPiramide()
        {
            bool teisingasSk = false;
            int skaicius;
            while (!teisingasSk)
            {
                Console.WriteLine("Iveskite skaiciu nuo 1 iki 9");
                skaicius = Convert.ToInt32(Console.ReadLine());
                StringBuilder sb = new StringBuilder();
                int sekaZemyn = skaicius;
                if (skaicius > 1 && skaicius < 9)
                {
                    Console.WriteLine();
                    teisingasSk = true;
                    for (int i = 1; i <= skaicius*2; i++)
                    {
                        if (i < skaicius)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                sb.Append(i);

                            }
                        }
                        else if (i >= skaicius)
                        {
                            
                            for (int j = sekaZemyn; j > 0; j--)
                            {
                                sb.Append(sekaZemyn);

                            }
                            sekaZemyn--;
                        }
                        Console.WriteLine(sb);
                        sb.Clear();
                    }
                }
            }

        }

        public static void uzduotis8SkaiciuEile()
        {
            Console.WriteLine("Koki skaiciu noretumete atvaizduoti?");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek kartu noretumete atvaizduoti?");
            int kartai = Convert.ToInt32(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= kartai; i++)
            {
                sb.Append("-> ");
                for(int j = 0; j < i; j++)
                {
                    sb.Append(skaicius);
                }
            }
            Console.WriteLine(sb);
        }

        public static void uzduotis9DaugybosLentele()
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                sb.Append(skaicius).Append(" X ").Append(i).Append(" = ").Append(skaicius * i);
                Console.WriteLine(sb);
                sb.Clear();
            }
        }


        //============================SKAICIUOTUVAS============================

/*        static void skaiciuotuvasMain()
        {
            bool pereitiPrieSubMeniu = false;
            int pasirinkimas;
            while (true)
            {
                while (!pereitiPrieSubMeniu)
                {
                    Console.WriteLine("1) Nauja operacija");
                    Console.WriteLine("2) Testi su rezultatu");
                    Console.WriteLine("3) Iseiti");
                    pasirinkimas = Convert.ToInt32(Console.ReadLine());
                    skaiciuotuvoMeniu(pasirinkimas);
                }
            }
        }

        public static void skaiciuotuvoMeniu(int pasirinkimas)
        {
            switch (pasirinkimas)
            {
                case 1:
                    skaiciuotuvoSubMeniu();
                    break;
                default:
                    break;
            }
        }

*//*        public static void skaiciuotuvoSubMeniu()
        {
            int pasirinkimas;
            Console.WriteLine("1) Sudetis");
            Console.WriteLine("2) Atimtis");
            Console.WriteLine("3) Daugyba");
            Console.WriteLine("4) Dalyba");
            pasirinkimas = Convert.ToInt32(Console.ReadLine());
            switch (pasirinkimas)
            {
                case 1:
                    sudetis();
                    break;
                default:
                    break;
            }
        }

       *//* public static double sudetis()
        {
            Console.WriteLine("Iveskite du skaicius");

        }*/
    }
}