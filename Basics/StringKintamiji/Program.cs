using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            teorineDalis();
        }
        static void teorineDalis()
        {
            string hello = "Hello";
            string world = " World!";

            string tuscias = "";
            string nulas = null;
            string laisvaerdve = "";

            string raideA = "AAAAAAAAAAAA";
            string raideB = raideA.Replace("A", "B"); // replace kabutese rasom pirma is ko keiciam(is A) ir tada i ka keiciam(i B)

            //Galima naudoti tuos pacius tris su visais string kintamaisiai

            string konkatinacija = hello + world;
            Console.WriteLine(konkatinacija);

            string kompozicija = String.Format("{0}{1}", hello, world);
            Console.WriteLine(kompozicija);

            string interpoliacija = $"{hello}{world}";
            Console.WriteLine(interpoliacija);

            Console.WriteLine(raideB);
        }

    }
}
