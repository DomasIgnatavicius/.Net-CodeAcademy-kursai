Console.WriteLine("Hello, sring!");

//Console.WriteLine("kazkas");
string b = Console.ReadLine();
//ConsoleKeyInfo c = Console.ReadKey();


Console.WriteLine("String manipuliacijos");

Console.WriteLine("****** string constructor");
char[] letters = { 'H', 'e', 'l', 'l', 'o' }; //array
string greetings = new string(letters); //string constructor
string vardas = "Petras";
DateTime siandien = DateTime.Today;

Console.WriteLine(greetings);

Console.WriteLine(letters[1]);
Console.WriteLine(greetings[1]);
Console.WriteLine(vardas[2]);

//---------------------------
Console.WriteLine("****** string concationation");
var pilnasVardas = vardas + " Pavardenis";
Console.WriteLine(pilnasVardas);

//---------------------------
Console.WriteLine("****** string composition");
var vardasIrData = string.Format("{0} data={1}", vardas, siandien);
Console.WriteLine(vardasIrData);

//---------------------------
Console.WriteLine("****** string interpolation");
var vardasIrData1 = $"{vardas} data={siandien}";
Console.WriteLine(vardasIrData1);

//-----------------------
Console.WriteLine("------------------------------------");
string nullas = null;
string baltaErdve = "                           ";
string tuscia = "";
string tuscia1 = string.Empty;
Console.WriteLine("ar \"\" yra tapatu string.Empty? {0}", tuscia == tuscia1);
Console.WriteLine("ar \"\" yra tapatu baltaErdve? {0}", tuscia == baltaErdve);
bool arTuscia = string.IsNullOrEmpty(tuscia);
Console.WriteLine($"arTuscia={arTuscia}");

bool arNullas = string.IsNullOrEmpty(nullas);
Console.WriteLine($"arNullas={arNullas}");

bool arBaltaErdveYraTuscia = string.IsNullOrEmpty(baltaErdve);
Console.WriteLine($"arBaltaErdveYraTuscia={arBaltaErdveYraTuscia}");

bool arBaltaErdve = string.IsNullOrWhiteSpace(baltaErdve);
Console.WriteLine($"arBaltaErdve={arBaltaErdve}");

//-----------------------
Console.WriteLine("------------------------------------");
string aa1 = "kabute = \"";
string aa2 = "kabute = \\";
string aa3 = "kabute = \n";
string aa4 = $"elute  {Environment.NewLine} nauja";
string aa5 = $"kelias diskinėje sistemoje {Path.DirectorySeparatorChar}program files{Path.DirectorySeparatorChar}windows";
string aa6 = $"{{  }}";
string aa7 = @" galime
rasyti teksta
per \ { @ "" 
kelias eilutes";

//-----------------------
Console.WriteLine("------------------------------------");
double skaicius = 22222.656646564665646;
string skaiciusSuApribotuKiekiuPoKablelio = skaicius.ToString("0.00");
Console.WriteLine(skaiciusSuApribotuKiekiuPoKablelio);




//-----------------------
Console.WriteLine("------------------------------------");

Console.WriteLine("******** TryParse ******** ");

string v1 = null;
string v2 = "160519";
string v3 = "9432.0";
string v4 = "16,667";
string v5 = "   -322     ";
string v6 = " +4302";
string v7 = "(100)";
string v8 = "01FA";
string v9 = "0x01FA";
string v10 = "001";

bool success1 = int.TryParse(v1, out int number1);
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v1, success1);
bool success2 = int.TryParse(v2, out _);
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v2, success2);
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v3, double.TryParse(v3, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v4, double.TryParse(v4, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v5, int.TryParse(v5, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v6, int.TryParse(v6, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v7, int.TryParse(v7, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v8, int.TryParse(v8, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v9, int.TryParse(v9, out _));
Console.WriteLine("Attempted conversion of '{0}'  . passed - {1}", v10, int.TryParse(v10, out _));

//--------------------------------------
//STRING METODAI
Console.WriteLine("-----------------------------------------");
Console.WriteLine("******** Clone() string dalies klonavimas ******** ");
{
    var vardas_2 = vardas.Clone();
    var vardas_3 = vardas;
    Console.WriteLine($"klonuotas vardas {vardas_2} ");
}
//-----------------------
{
    Console.WriteLine("******** CompareTo() string palyginimas ********");
    string strFirst = "Goodbye";
    string strSecond = "Hello";
    int cmpVal = strFirst.CompareTo(strSecond);
    //grazins -1 jei strFirst < strSecond
    //grazins 0 jei strFirst = strSecond
    //grazins 1 jei strFirst > strSecond
}
//-----------------------
var netvarkingasTekstas = " Kazkoks NEtvarkingAS Tekstas Su tarPais ir 155 0051 skaičiais ";

{
    Console.WriteLine("******** Contains() paieška string viduje ******** ");
    string etr = " etr";
    Console.WriteLine($"ar vardas {vardas} viduje turi {etr}? {vardas.Contains(etr)}");
    Console.WriteLine($"ar vardas {netvarkingasTekstas} viduje turi 'AS Te'? {netvarkingasTekstas.Contains("AS Te")}");
}
//-----------------------
{
    Console.WriteLine("******** EndsWith() paieška string gale ******** ");
    Console.WriteLine($"ar vardas {vardas} pradideda 'nas'? {vardas.EndsWith("nas")}");
    Console.WriteLine($"ar vardas {vardas} pradideda 'ras'? {vardas.EndsWith("ras")}");
}
//-----------------------
{
    Console.WriteLine("******** Equals() string palyginimas ********");
    string vardasIsMazosios = "petras";
    bool arVardaiLygus = vardas == vardasIsMazosios;
    Console.WriteLine($"ar vardas {vardas} viduje lygus {vardasIsMazosios}? {arVardaiLygus}");
    bool arVardaiLygus1 = vardas.Equals(vardasIsMazosios, StringComparison.InvariantCultureIgnoreCase);
    Console.WriteLine($"ar vardas {vardas} viduje lygus {vardasIsMazosios} su IgnoreCase: {arVardaiLygus1}");
}
//-----------------------
{
    Console.WriteLine("******** IndexOf() grąžina indeksą pirmo sutikto atitikmens ******** ");
    Console.WriteLine(netvarkingasTekstas);
    Console.WriteLine("e raidės indeksas " + netvarkingasTekstas.IndexOf("e")); //grazina 23
    Console.WriteLine("a raidės indeksas " + netvarkingasTekstas.IndexOf("a")); //grazina 2
    Console.WriteLine("x raidės indeksas " + netvarkingasTekstas.IndexOf("x")); //grazina -1
}
//-----------------------
{
    Console.WriteLine("******** ToLower() visas raides padaro mažosiom ******** ");
    var tekstasSuTarpaisMazosiomis = netvarkingasTekstas.ToLower();
    Console.WriteLine($"tekstasSuTarpais mažosiomis ({tekstasSuTarpaisMazosiomis}).");
}
//-----------------------
{
    Console.WriteLine("******** ToUpper() visas raides padaro didziosiom ******** ");
    var tekstasSuTarpaisDidziosiomis = netvarkingasTekstas.ToUpper();
    Console.WriteLine($"tekstasSuTarpais didžiosiomis ({tekstasSuTarpaisDidziosiomis}).");
}
//-----------------------
{
    Console.WriteLine("******** Insert() įterpia teksta nurodytoje vietoje ******** ");
    Console.WriteLine(vardas.Insert(2, "_Hello_"));
}
//-----------------------
{
    Console.WriteLine("******** LastIndexOf() grąžina indeksą paskutinio sutikto atitikmens ******** ");
    Console.WriteLine("e raidės paskutinis indeksas " + netvarkingasTekstas.LastIndexOf("e")); //grazina 23
    Console.WriteLine("a raidės paskutinis indeksas " + netvarkingasTekstas.LastIndexOf("a")); //grazina 59
    Console.WriteLine("x raidės paskutinis indeksas " + netvarkingasTekstas.LastIndexOf("x")); //grazina -1
}
//-----------------------
{
    Console.WriteLine("******** Length string ilgis (simboliu kiekis)  ********");
    Console.WriteLine(vardas.Length);
}
//-----------------------
{
    Console.WriteLine("******** Remove() pašalna simbolius  ********");
    Console.WriteLine(vardas.Remove(2)); //iki galo

    Console.WriteLine(vardas.Remove(0, 1)); //kiek nurodyta
    Console.WriteLine(vardas.Remove(vardas.Length - 1, 1));
}
//-----------------------
{
    Console.WriteLine("******** Replace() raidžių keitimas string viduje ******** ");
    var pakeistasaTekstas = netvarkingasTekstas.Replace("a", "_=_");
    Console.WriteLine($"pakeistasa tekstas {pakeistasaTekstas} ");
}
//-----------------------
{
    Console.WriteLine("******** Split() teksto skaidymas ******** ");
    string[] split = vardas.Split('e'); //Split the string based on specified value
    Console.WriteLine(split[0]);
    Console.WriteLine(split[1]);
}
//-----------------------
Console.WriteLine("******** StartsWith() paieška string pradžioje ******** ");
{
    Console.WriteLine($"ar vardas {vardas} pradideda 'Jon'? {vardas.StartsWith("Jon")}");
}
//-----------------------
{
    Console.WriteLine("******** Substring() dalies string nuskaitymas ******** ");
    var dalisTeksto = netvarkingasTekstas.Substring(2);
    Console.WriteLine($"dalis teksto {dalisTeksto} ");

    var dalisTeksto1 = netvarkingasTekstas.Substring(2, 10);
    Console.WriteLine($"dalis teksto {dalisTeksto1} ");
}
//-----------------------
{
    Console.WriteLine("******** Trim() tekstas su tarpais trim ******** ");

    Console.WriteLine($"tekstasSuTarpais ({netvarkingasTekstas}).");
    Console.WriteLine($"tekstasSuTarpais su išvalytais gale ir priekyje ({netvarkingasTekstas.Trim()}).");
    Console.WriteLine($"tekstasSuTarpais su išvalytais priekyje  ({netvarkingasTekstas.TrimStart()}).");
    Console.WriteLine($"tekstasSuTarpais su išvalytais gale ({netvarkingasTekstas.TrimEnd()}).");

}