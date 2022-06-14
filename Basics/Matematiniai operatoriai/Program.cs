using System.Text;


teorija();





void teorija()
{
    Console.WriteLine("Hello, Priskyrimo operatoriai = += -= *= /=");
    int skaicius;
    int kitasSkaicius = 20;
    int nelyginisSkaicius = 5;
    skaicius = 10;
    kitasSkaicius = skaicius;
    Console.WriteLine($"skaicius = {skaicius}, kitasSkaicius = {kitasSkaicius}");

    kitasSkaicius += nelyginisSkaicius; // kitasSkaicius = kitasSkaicius + nelyginisSkaicius //tai analogas
    Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

    kitasSkaicius -= nelyginisSkaicius;
    Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

    kitasSkaicius *= nelyginisSkaicius;
    Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

    kitasSkaicius /= nelyginisSkaicius;
    Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

    kitasSkaicius = 21;

    kitasSkaicius /= nelyginisSkaicius;
    Console.WriteLine($"kitasSkaicius = {kitasSkaicius}");

    double doubleSkaicius = 21;
    doubleSkaicius /= (double)nelyginisSkaicius;
    Console.WriteLine($"doubleSkaicius = {doubleSkaicius}");

    Console.WriteLine();
    Console.WriteLine("Hello, matematiniai operatoriai + - * / % ++ --");
    //sudetis
    int suma = skaicius + kitasSkaicius;
    Console.WriteLine("   suma = skaicius+kitasSkaicius = {0}", suma);
    int atimtis = skaicius - kitasSkaicius;
    Console.WriteLine("   atimtis = skaicius-kitasSkaicius = {0}", atimtis);
    int daugyba = skaicius * kitasSkaicius;
    Console.WriteLine("   daugyba = skaicius*kitasSkaicius = {0}", daugyba);
    double dalyba = (double)skaicius / kitasSkaicius;
    Console.WriteLine("   dalyba = skaicius/kitasSkaicius = {0}", dalyba);

    int matematinisRezultatas = 1 + 2 - 3 + 4 + nelyginisSkaicius - skaicius;

    int dalybaSuLiekana = nelyginisSkaicius % 2;
    Console.WriteLine("   dalybaSuLiekana = nelyginisSkaicius % 2 = {0}", dalybaSuLiekana);

    skaicius++;
    Console.WriteLine($"   skaicius={skaicius}");

    skaicius--;
    Console.WriteLine($"   skaicius={skaicius}");

    //area of a trapezoid (https://lt.wikipedia.org/wiki/Trapecija)
    double side1 = 5.5;
    double side2 = 3.25;
    double height = 4.6;
    double area = (side1 + side2) / 2 * height;

    double areaKazkasKito = ((side1 * 2) + side2) / (2 * height);

    Console.OutputEncoding = Encoding.UTF8;
    int nulis = 0;
    int int10 = 10;
    long long10 = 10;
    double double10 = 10;
    //Console.WriteLine( $"int10/nulis={ int10/nulis }"); //luzta
    //Console.WriteLine( $"long10/nulis={long10 / nulis }"); //luzta
    Console.WriteLine($"double10/nulis={double10 / nulis }"); // grazina ∞ - ty  begalybės implementacija
    double a = double.PositiveInfinity;
    Console.WriteLine($"a={a}");

    Console.WriteLine($"{a == double.PositiveInfinity}");
    Console.WriteLine($"{a == double.NegativeInfinity}");
    Console.WriteLine($"a - 500 = {a - 500}");

    double a1 = double.NaN;
    Console.WriteLine($"∞/∞={a / double.PositiveInfinity}");

    //***** Overflow and Underflow
    short s1 = 30_000;
    short s2 = 30_000;
    short s3 = (short)(s1 + s2);
    Console.WriteLine($"s3={s3}");
    //checked
    //{
    //    s3 = (short)(s1 + s2);
    //}
}

void uzduotys()
{
    // See https://aka.ms/new-console-template for more information
    Console.WriteLine("Hello, World!");
    /*
              ************************************************************************************************************************
             PARAŠYTI PROGRAMĄ, KURIOJE VARTOTOJO PRAŠOMA ĮVESTI 2 SKAIČIUS.PROGRAMA TURI IŠVESTI
             • SKAIČIŲ SUMĄ
             • SKAIČIŲ SKIRTUMĄ
             • SANDAUGĄ
             • DALYBĄ
             */
    Console.WriteLine("iveskite pirma skaiciu");
    int skaicius1 = int.Parse(Console.ReadLine());
    Console.WriteLine("iveskite antra skaiciu");
    double skaicius2 = double.Parse(Console.ReadLine());
    Console.WriteLine($"{skaicius1}+{skaicius2}={skaicius1 + skaicius2}");
    Console.WriteLine($"{skaicius1}-{skaicius2}={skaicius1 - skaicius2}");
    Console.WriteLine($"{skaicius1}*{skaicius2}={skaicius1 * skaicius2}");
    Console.WriteLine($"{skaicius1}/{skaicius2}={skaicius1 / skaicius2}");
    /*
     ************************************************************************************************************************
    PARAŠYTI PROGRAMĄ, 3 SKAIČIUS. PROGRAMA TURI IŠVESTI ŠIŲ SKAIČIŲ VIDURKĮ
    */
    Console.WriteLine("iveskite pirma skaiciu");
    int skaicius21 = int.Parse(Console.ReadLine());
    Console.WriteLine("iveskite antra skaiciu");
    int skaicius22 = int.Parse(Console.ReadLine());
    Console.WriteLine("iveskite trecia skaiciu");
    int skaicius32 = int.Parse(Console.ReadLine());
    Console.WriteLine("vidurkis = {0}", (double)(skaicius21 + skaicius22 + skaicius32) / 3);

    /*
     sukurkite naują kintamajį long ir prskirkite didžiausią reikšmę. 
     sukurkite naują kintamajį short ir prskirkite didžiausią reikšmę
      - padalinkite didesnį skaičių iš mažesnio
      - iš rezultato atimkite maksimalų long skaičių
      - ir pridėkite maksimalų int skaičių
     */
}
