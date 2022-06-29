namespace P010_Methods_Uzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {

            uzduotis4();

            
        }

        // -----------------------------UZDUOTYS--------------------

        public static void uzduotis1()
        {
            /* Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą. 
            - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais 
            - Įvestas tekstas metodui perduodamas per parametrus ir grąžina žodžių kiekį 
            - Main metode į ekraną išveskite žodžių kiekį
            Pvz: 
            > Iveskite teksta:
            _ as mokausi programuoti
            > Zodziu kiekis yra: 3*/
            Console.WriteLine("Iveskite teksta: ");
            string textas = Console.ReadLine();
            Console.WriteLine(kiekSakinyjeZodziu(textas));
        }

        public static void uzduotis2()
        {
            /*Parašykite programą kurioje vienas metodas. 
            - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
            - Metodas grąžina tarpų kiekį teksto gale
            - Main į ekraną išveda rezultatą
            Pvz: 
            > Iveskite teksta:
            _ ' as mokausi      '
            > Gale yra tarpų: 6*/

            Console.WriteLine("Iveskite texta: ");
            string textas = Console.ReadLine();
            Console.WriteLine(kiekTarpuGale(textas));
        }

        public static void uzduotis3()
        {
            /* Parašykite programą kurioje vienas metodas. 
           - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
           - Metodas grąžina tarpų kiekį teksto pradžioje
           - Main į ekraną išveda rezultatą
           Pvz: 
           > Iveskite teksta:
           _ ' as mokausi      '
           > Pradžioje yra tarpų: 1*/

            Console.WriteLine("Iveskite texta: ");
            string textas = Console.ReadLine();
            Console.WriteLine(kiekTarpuPriekyje(textas));
        }

        public static void uzduotis4()
        {
            /* Parašykite programą kurioje vienas metodas. 
          - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
          - Metodas grąžina dvi reikšmes pirmoji - tarpų kiekį teksto pradžioje, antroji - tarpų kiekį teksto gale
            <hint> naudoti out 
          - Main į ekraną išveda rezultatą
          Pvz: 
          > Iveskite teksta:
          _ ' as mokausi      '
          > Pradžioje yra tarpų: 1
          > Gale yra tarpų: 6*/

            Console.WriteLine("Iveskite texta: ");
            string textas = Console.ReadLine();
            Console.WriteLine();
            int tarpaiGale;
            int tarpaiPriekyje = kiekTarpuPriekyjeirGale(textas, out tarpaiGale);
            Console.WriteLine($"Tarpu priekyje yra {tarpaiPriekyje}, tarpu gale yra {tarpaiGale}");
        }



        //---------------------UZDUOCIU METODAI---------------------



        // 1 UZDUOTIS
        public static int kiekSakinyjeZodziu(string text)
        {
            string whole_text = text;
            string trimmed_text = whole_text.Trim();
            string[] split_text = trimmed_text.Split(' ');
            int space_count = 0;
            string new_text = "";

            foreach (string av in split_text)
            {
                if (av == "")
                {
                    space_count++;
                }
                else
                {
                    new_text = new_text + av + ",";
                }
            }
            new_text = new_text.TrimEnd(',');
            split_text = new_text.Split(',');
            return split_text.Length;
        }

        // 2 UZDUOTIS
        public static int kiekTarpuGale(string text)
        {
            int ilgisSuTarpais = text.Length;
            string patrimintas = text.TrimEnd();
            int ilgisBeTarpu = patrimintas.Length;
            return ilgisSuTarpais - ilgisBeTarpu;
        }

        // 3 UZDUOTIS
        public static int kiekTarpuPriekyje(string text)
        {
            int ilgisSuTarpais = text.Length;
            string patrimintas = text.TrimStart();
            int ilgisBeTarpu = patrimintas.Length;
            return ilgisSuTarpais - ilgisBeTarpu;
        }

        // 4 UZDUOTIS
        public static int kiekTarpuPriekyjeirGale(string text, out int tarpaiGale)
        {
            int ilgisSuTarpais = text.Length;
            string patrimintas = text.TrimEnd();
            int ilgisBeTarpu = patrimintas.Length;
            tarpaiGale = ilgisSuTarpais - ilgisBeTarpu;
            ilgisSuTarpais = text.Length;
            patrimintas = text.TrimStart();
            ilgisBeTarpu = patrimintas.Length;
            return ilgisSuTarpais - ilgisBeTarpu ;
        }


    }
}