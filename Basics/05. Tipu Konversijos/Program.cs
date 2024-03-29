﻿namespace P004_TipuKonversijos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Tipu konversijos!");
            // Implicit casting
            int skaiciusInt = 100;
            long skaiciusLong = 100;
            long castintasLong = (long)skaiciusInt;
            long castintasLong1 = skaiciusInt; //tipo konversija daroma automatiškai

            var castintasLong2 = (long)skaiciusInt;

            byte skaiciusByte = 200;
            int skaiciusInt2 = skaiciusByte;
            long skaiciusLong2 = skaiciusByte;
            long skaiciusLong3 = skaiciusInt2;
            float skaiciusFloat = skaiciusByte;
            float skaiciusFloat1 = skaiciusInt2;
            float skaiciusFloat2 = skaiciusLong2;
            double skaiciusDouble = skaiciusByte;
            double skaiciusDouble1 = skaiciusInt2;
            double skaiciusDouble2 = skaiciusLong2;
            double skaiciusDouble3 = skaiciusFloat2;
            decimal skaiciusDecimal = skaiciusByte;
            //Byte->short->int->long->float->double->decimal

            //Explicit casting
            int castintasInt = (int)skaiciusLong;
            //decimal -> double -> float -> long -> int -> char
            float fl = 5.9f;
            int castintasint1 = (int)fl;
            Console.WriteLine("  i={0}", castintasint1);

            char skaiciusRaide = 'a';
            int castintasInt2 = skaiciusRaide;
            Console.WriteLine($"  castintasInt2={castintasInt2} ");
            long castintasLong3 = skaiciusRaide;
            //char->ushort->int->uint->long->ulong->float->double->decimal

            //string a = "a";
            //int castintasInt3 = (int)a;

            long skaiciusLongDidesnis = 3_000_000_000;
            int castintasInt4 = (int)skaiciusLongDidesnis;
            Console.WriteLine($"   castintasInt4={castintasInt4}");

            long skaiciusLongDarDidesnis = long.MaxValue;
            int castintasInt5 = (int)skaiciusLongDarDidesnis;
            Console.WriteLine($"  castintasInt5={castintasInt5}");


            //*** Type Conversion Methods
            string konvertuotasString = Convert.ToString(skaiciusInt);
            string konvertuotasString1 = skaiciusInt.ToString();
            long konertuotasLong = Convert.ToInt64(skaiciusInt);
            double konvertuotasDouble = Convert.ToDouble(skaiciusInt);

            //int konvertuotasInt = Convert.ToInt32(skaiciusLongDidesnis); //Luzta nes netelpa

            //darbas su nullable tipais
            int? skaiciusIntNull = null;
            //long castintasLong5 = (long)skaiciusIntNull; //Luzta
            long konvertuotasLong1 = Convert.ToInt64(skaiciusIntNull); //programa neluzta, o grąžinama long tipo default reikšmė ty 0
            Console.WriteLine($"   konvertuotasLong1 = {konvertuotasLong1}");

            //parsinimas
            string skaiciusString = "100";
            string skaiciusDidelisString = "999999999999999999";
            string tekstas = "tekstas";
            int skaiciusIntParsintas = int.Parse(skaiciusString);
            Console.WriteLine($"   skaiciusString + 1 = {skaiciusString + 1}");
            Console.WriteLine($"   skaiciusIntParsintas + 1 = {skaiciusIntParsintas + 1}");

            //int skaiciusIntParsintas1 = int.Parse(skaiciusDidelisString);
            //int tekstasIntParsintas = int.Parse(tekstas);


        }
    }
}