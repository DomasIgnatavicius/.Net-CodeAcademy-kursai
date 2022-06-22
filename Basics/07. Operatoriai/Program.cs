loginiaiUzduotis2();

void teorija()
{
    Console.WriteLine("Hello, Operatoriai!");

    //Reliaciniai operatoriai == != > < >= <=
    var skaicius = 10;
    var nelyginisSkaicius = 5;
    var lyginisSkaicius = 10;
    Console.WriteLine(" == patikrina ar kintamieji yra lygūs");
    Console.WriteLine($" {skaicius}=={lyginisSkaicius} yra {skaicius == lyginisSkaicius}");
    bool ar10yraLygu5 = skaicius == nelyginisSkaicius;
    Console.WriteLine($" {skaicius}=={nelyginisSkaicius} yra {ar10yraLygu5}");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine(" != patikrina ar kintamieji yra nelygūs");
    Console.WriteLine($" {skaicius}!={lyginisSkaicius} yra {skaicius != lyginisSkaicius}");
    Console.WriteLine($" {skaicius}!={nelyginisSkaicius} yra {skaicius != nelyginisSkaicius}");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine(" > patikrina ar kairėje esanti reikšmė yra didensė už dešinėje");
    Console.WriteLine($" {skaicius}>{lyginisSkaicius} yra {skaicius > lyginisSkaicius}");
    Console.WriteLine($" {skaicius}>{nelyginisSkaicius} yra {skaicius > nelyginisSkaicius}");

    Console.WriteLine("-----------------------------------");
    Console.WriteLine(" < patikrina ar kairėje esanti reikšmė yra mazesne už dešinėje");
    Console.WriteLine($" {skaicius}<{lyginisSkaicius} yra {skaicius < lyginisSkaicius}");
    Console.WriteLine($" {skaicius}<{nelyginisSkaicius} yra {skaicius < nelyginisSkaicius}");

    Console.WriteLine("-----------------------------------");
    Console.WriteLine(" >= patikrina ar kairėje esanti reikšmė yra didensė arba lygi už dešinėje");
    Console.WriteLine($" {skaicius}>={lyginisSkaicius} yra {skaicius >= lyginisSkaicius}");
    Console.WriteLine($" {skaicius}>={nelyginisSkaicius} yra {skaicius >= nelyginisSkaicius}");

    Console.WriteLine("-----------------------------------");
    Console.WriteLine(" <= patikrina ar kairėje esanti reikšmė yra mažesnė arba lygi už dešinėje");
    Console.WriteLine($" {skaicius}<={lyginisSkaicius} yra {skaicius <= lyginisSkaicius}");
    Console.WriteLine($" {skaicius}<={nelyginisSkaicius} yra {skaicius <= nelyginisSkaicius}");
}

void loginiaiOperatoriaiTeorija()
{
    Console.WriteLine("Hello Loginiai Operatoriai!");
    Console.WriteLine("&& (AND) , || (OR) , ! (NOT) , ^ (XOR)");
    Console.WriteLine();

    Console.WriteLine("Neigimas !");
    bool tiesa = true;
    bool melas = !tiesa;

    Console.WriteLine($"Tiesa = {tiesa}");
    Console.WriteLine($"Melas = {melas}");
    Console.WriteLine($"!Melas = {!melas}");
    Console.WriteLine($"!Tiesa = {!tiesa}");
    Console.WriteLine();

    Console.WriteLine("AND &&");
    Console.WriteLine($"tiesa AND tiesa  {tiesa && tiesa}");
    Console.WriteLine($"tiesa AND melas  {tiesa && melas}");
    Console.WriteLine($"melas AND tiesa  {melas && tiesa}");
    Console.WriteLine($"melas AND melas  {melas && melas}");
    Console.WriteLine();

    Console.WriteLine("OR ||");
    Console.WriteLine($"tiesa OR tiesa  {tiesa || tiesa}");
    Console.WriteLine($"tiesa OR melas  {tiesa || melas}");
    Console.WriteLine($"melas OR tiesa  {melas || tiesa}");
    Console.WriteLine($"melas OR melas  {melas || melas}");
    Console.WriteLine();

    Console.WriteLine("XOR ^"); // kai vienodi grazina false
    Console.WriteLine($"tiesa XOR tiesa  {tiesa ^ tiesa}");
    Console.WriteLine($"tiesa XOR melas  {tiesa ^ melas}");
    Console.WriteLine($"melas XOR tiesa  {melas ^ tiesa}");
    Console.WriteLine($"melas XOR melas  {melas ^ melas}");
    Console.WriteLine();

    Console.WriteLine("NAND !(AND)"); // NOT AND, dvieju operatoriu kombinacija, AND operatoriaus paneigimas
    Console.WriteLine($"tiesa NAND tiesa  {!(tiesa && tiesa)}");
    Console.WriteLine($"tiesa NAND melas  {!(tiesa && melas)}");
    Console.WriteLine($"melas NAND tiesa  {!(melas && tiesa)}");
    Console.WriteLine($"melas NAND melas  {!melas && !melas}");
    Console.WriteLine();

    Console.WriteLine("NOR !(OR)"); // NOT OR, dvieju operatoriu kombinacija, OR operatoriaus paneigimas
    Console.WriteLine($"tiesa NOR tiesa  {!(tiesa || tiesa)}");
    Console.WriteLine($"tiesa NOR melas  {!(tiesa || melas)}");
    Console.WriteLine($"melas NOR tiesa  {!(melas || tiesa)}");
    Console.WriteLine($"melas NOR melas  {!melas || !melas}"); // nelabai geras, nes atliekam 3 veiksmus vietoj dvieju
    Console.WriteLine();

    Console.WriteLine("NXOR !(XOR)"); // NOT XOR, dvieju operatoriu kombinacija, XOR operatoriaus paneigimas
    Console.WriteLine($"tiesa NXOR tiesa  {!(tiesa ^ tiesa)}");
    Console.WriteLine($"tiesa NXOR melas  {!(tiesa ^ melas)}");
    Console.WriteLine($"melas NXOR tiesa  {!(melas ^ tiesa)}");
    Console.WriteLine($"melas NXOR melas  {!melas ^ !melas}");
    Console.WriteLine();
    Console.WriteLine("---------------------------------------------------------");
    Console.WriteLine();

    int a = 5;
    int b = 5;
    int c = 6;
    bool s = a >= b && a > c;
    Console.WriteLine(s);
}

// Loginiai operatoriai UZDUOTYS

void loginiaiUzduotis1()
{
    //PRASO IVESTI DU SKAICIUS, JIE LYGUS ISVEDA TRUE, JEI NE ISVEDA FALSE
    Console.WriteLine("iveskite du skaicius");
    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Ar skaiciai lygus?: {a == b}");
}

void loginiaiUzduotis2()
{
    //PRASO IVESTI DU SKAICIUS, JIE LYGUS ISVEDA TRUE, JEI NE ISVEDA FALSE
}
