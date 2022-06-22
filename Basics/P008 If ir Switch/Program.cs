
var ifUzduotis = new ifUzuodys();

ifUzduotis.kaleduSausainiai();

void ifTeorija()
{
    int nelyginisSkaicius = 5;
    int lyginisSkaicius = 2;
    bool tiesa = true;

    if (nelyginisSkaicius > lyginisSkaicius)
    {
        Console.WriteLine($"  {nelyginisSkaicius} yra didesnis uz {lyginisSkaicius}");
    }

    if (nelyginisSkaicius < lyginisSkaicius)
    {
        Console.WriteLine($"  {nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius}");
    }

    Console.WriteLine("if - else");
    if (nelyginisSkaicius < lyginisSkaicius)
    {
        Console.WriteLine($"  {nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius}");
    }
    else
    {
        Console.WriteLine($"  {nelyginisSkaicius} yra didesnis uz {lyginisSkaicius}");
    }


    Console.WriteLine("if - else if - else");
    if (nelyginisSkaicius < lyginisSkaicius && tiesa)
    {
        Console.WriteLine($"  {nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius} ir tiesa yra true");
    }
    else if (nelyginisSkaicius < lyginisSkaicius && !tiesa)
    {
        Console.WriteLine($"  {nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius} ir tiesa yra false");
    }
    else if (nelyginisSkaicius > lyginisSkaicius && tiesa)
    {
        Console.WriteLine($"  {nelyginisSkaicius} yra didesnis uz {lyginisSkaicius} ir tiesa yra true");
    }
    else
    {
        Console.WriteLine($"  {nelyginisSkaicius} yra didesnis uz {lyginisSkaicius} ir tiesa yra false");
    }

    Console.WriteLine("----------------------------");
    var score = 45;
    int pointNeededToPass = 100;
    bool leverComplete = false;
    if (score >= pointNeededToPass) leverComplete = true;
    // else leverComplete = false;

    if (leverComplete)
    {
        Console.WriteLine("valio, baigete lygi");
    }

    Console.WriteLine(score >= pointNeededToPass ? "valio, baigete lygi" : "nevalio, turite dar kart");


    Console.WriteLine("----------------------------");
    Console.WriteLine("if kompozicija, nesting");
    int shields = 1, armor = 2;
    if (shields <= 0)
    {
        if (armor <= 0)
        {
            Console.WriteLine("jus mires");
        }
        else
        {
            Console.WriteLine("jus dar turite armor");
        }
    }
    else
    {
        Console.WriteLine("Jus dar turite galimybiu");
    }

    if (shields <= 0 && armor <= 0)
    {
        Console.WriteLine("jus mires");
    }
    else if (shields <= 0 && armor > 0)
    {
        Console.WriteLine("jus dar turite armor");
    }
    else
    {
        Console.WriteLine("Jus dar turite galimybiu");
    }

    Console.WriteLine("----------------------------");
    Console.WriteLine("null-coalescing operator (??)");
    bool? nullableBool = true;
    bool normalBool;
    //normalBool = nullableBool; //taip negalima
    normalBool = nullableBool ?? false;
    //---------------
    nullableBool ??= false;

    Console.WriteLine("--Press any key to continue--");
}

void switchTeorija()
{
    Console.WriteLine("Hello, switch!");
    Console.WriteLine(" Iveskite meniu punkta");
    int menuChoice = Convert.ToInt32(Console.ReadLine());
    switch (menuChoice)
    {
        case 1:

            Console.WriteLine("Vartotojas pasirinko 1");
            Console.WriteLine("dar kazkokia info");
            break;
        case 2:
            Console.WriteLine("Vartotojas pasirinko 2");
            break;
        case 3:
            Console.WriteLine("Vartotojas pasirinko 3");
            break;
        case 4:
            Console.WriteLine("Vartotojas pasirinko 4");
            //Console.WriteLine($"Ivesta {h}");
            break;
        default: //Galima aprašyti default logiką, ji bus vykdoma jei nei vienas case neatitiko sąlygos
            Console.WriteLine("iveskite kazka");
            var h = Console.ReadLine();
            switch (h)
            {
                case "":
                    Console.WriteLine("nieko neivesta");
                    break;
            }
            Console.WriteLine($"KLAIDA {h}");
            break;
    }

    //--------------------------------------
    Console.WriteLine("--------------------------------------");
    var isvedamasRezultatas = menuChoice switch
    {
        1 => "Vartotojas pasirinko 1",
        2 => "Vartotojas pasirinko 2",
        3 => "Vartotojas pasirinko 3",
        _ => "Vartotojas nieko nepasirinko"
    };
    Console.WriteLine(isvedamasRezultatas);


    //--------------------------------------
    Console.WriteLine("--------------------------------------");
    switch (menuChoice)
    {
        case 1:
        case 2:
            Console.WriteLine("Vartotojas pasirinko 1 arba 2");
            break;
    }
}

class ifUzuodys
{
    public void pazymiai()
    {
        /*PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI
        EGZAMINO PAŽYMĮ. IŠVESTI:
        0 - 4: NEPATEKINAMAI
        5: SILPNAI
        6: PATENKINAMAI
        7: VIDUTINIŠKAI
        8: GERAI
        9: LABAI GERAI
        10: PUIKIAI*/

        Console.WriteLine("Iveskite egzamino pazymi");
        int pazimys = Convert.ToInt32(Console.ReadLine());
        if (pazimys == 10)
        {
            Console.WriteLine("PUIKIAI");
        }
        else if (pazimys == 9)
        {
            Console.WriteLine("LABAI GERAI");
        }
        else if (pazimys == 8)
        {
            Console.WriteLine("GERAI");
        }
        else if (pazimys == 7)
        {
            Console.WriteLine("VIDUTINISKAI");
        }
        else if (pazimys == 6)
        {
            Console.WriteLine("PATENKINAMAI");
        }
        else if (pazimys == 5)
        {
            Console.WriteLine("SILPNAI");
        }
        else if (pazimys == 4 || pazimys == 3 || pazimys == 2 || pazimys == 1)
        {
            Console.WriteLine("NEPATENKINAMAI");
        }
        else
        {
            Console.WriteLine("Ivestas netinkamas pazimys");
        }
    }

    public void nemokamaKava()
    {
        /*** Nemokama kava **
        Aprašykite int kintamajį kuriame nurodysite kiek puodelių kavos perkama. (tarkim 7)
        Kas 3 puodelis nemokamas. Paskaičiuokite ir išveskite į ekraną ar pirkėjui priklauso nemokama kava
        - Pavyzdžio atsakymas: "pirkėjui priklauso 2 nemokami puodeliai"
        - Alternatyvus atsakymas: "Pirkėjui nepriklauso nemokama kava"*/

        Console.WriteLine("Kiek puodeliu kavos pirksite?");
        int kava = Convert.ToInt32(Console.ReadLine());
        int nemokama;
        if (kava == 1 || kava == 2 || kava == 0)
        {
            Console.WriteLine("Pirkejui nepriklauso nemokami puodeliai");
        }
        else if (kava % 3 == 0)
        {
            nemokama = kava / 3;
            Console.WriteLine($"Pirkejui priklaudo {nemokama} nemokami puodeliai");
        }
        else {
            if ((kava - 1) % 3 == 0)
            {
                nemokama = (kava - 1) / 3;
                Console.WriteLine($"Pirkejui priklaudo {nemokama} nemokami puodeliai");
            }
            else if ((kava - 2) % 3 == 0)
            {
                nemokama = (kava - 2) / 3;
                Console.WriteLine($"Pirkejui priklaudo {nemokama} nemokami puodeliai");
            }
        }
    }

    public void priesingiSkaiciai()
    {
        /*Naudotojas įveda betkokius 4 sveikus skaicius (tarkim 5; 15; -25; 0;)
        - Parašykite programą kuri į ekraną išves neigiamą/teigiamą skaičiaus reikšmę
        - Pavyzdžio atsakymas 5 -> -5; 15 -> -15; -25 -> 25; 0 -> N/A;*/

        Console.WriteLine("Iveskite keturis skaicius");
        int pirmas = Convert.ToInt32(Console.ReadLine());
        int antras = Convert.ToInt32(Console.ReadLine());
        int trecias = Convert.ToInt32(Console.ReadLine());
        int ketvirtas = Convert.ToInt32(Console.ReadLine());

        int pirmasPakeistas;
        int antrasPakeistas;
        int treciasPakeistas;
        int ketvirtasPakeistas;

        if (pirmas > 0)
        {
            pirmasPakeistas = pirmas - 2 * pirmas;
        }
        else
        {
            pirmasPakeistas = pirmas + 2 * pirmas;
        }

        if (antras > 0)
        {
            antrasPakeistas = antras - 2 * antras;
        }
        else
        {
            antrasPakeistas = antras + 2 * antras;
        }

        if (trecias > 0)
        {
            treciasPakeistas = trecias - 2 * trecias;
        }
        else
        {
            treciasPakeistas = trecias + 2 * trecias;
        }

        if (ketvirtas > 0)
        {
            ketvirtasPakeistas = ketvirtas - 2 * ketvirtas;
        }
        else
        {
            ketvirtasPakeistas = ketvirtas + 2 * ketvirtas;
        }

        Console.WriteLine($"{pirmas} -> {pirmasPakeistas} {antras} -> {antrasPakeistas} {trecias} -> {treciasPakeistas} {ketvirtas} -> {ketvirtasPakeistas}");
    }

    public void zaidimasAtspekSkaicius()
    {
        /*ŽAIDIMAS ATSPĖK SKAIČIŲ
        - ĮHARDKODINAMAS BETKOKS SKAIČIUS NUO 1 IKI 20
        - NAUDOTOJAS 6 KARTUS PRAŠOMAS ĮVESTI SKAIČIŲ NUO 1 IKI 20
        - JEI NAUDOTOJAS ĮVEDĖ TEISINGAI - IŠVEDAMAS SVEIKINIMAS "TEISINGAI" IR PROGRAMA STABDOMA
        - JEI NAUDOTOJAS ĮVEDĖ PER MAŽĄ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA DIDESNIS"
        - JEI NAUDOTOJAS ĮVEDĖ PER DIDELĮ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA MAŽESNIS"
        nutraukiant programos vykdymą Environment.Exit(0) ar pan. naudoti negalima. Naudoti if.*/

        int teisingasSkacius = 11;
        Console.WriteLine("Turite 6 bandymus atspeti skaiciu");
        int pimras = Convert.ToInt32(Console.ReadLine());
        if(pimras == teisingasSkacius)
        {
            Console.WriteLine("TEISINGAI");
            return;
        }
        else if(pimras > teisingasSkacius)
        {
            Console.WriteLine("Ivestas skaicius yra didesnis uz teisinga");
        }
        else
        {
            Console.WriteLine("Ivestas skaicius yra mazesnis uz teisinga");
        }

        int antras = Convert.ToInt32(Console.ReadLine());
        if (antras == teisingasSkacius)
        {
            Console.WriteLine("TEISINGAI");
            return;
        }
        else if (antras > teisingasSkacius)
        {
            Console.WriteLine("Ivestas skaicius yra didesnis uz teisinga");
        }
        else
        {
            Console.WriteLine("Ivestas skaicius yra mazesnis uz teisinga");
        }

        int trecias = Convert.ToInt32(Console.ReadLine());
        if (trecias == teisingasSkacius)
        {
            Console.WriteLine("TEISINGAI");
            return;
        }
        else if (trecias > teisingasSkacius)
        {
            Console.WriteLine("Ivestas skaicius yra didesnis uz teisinga");
        }
        else
        {
            Console.WriteLine("Ivestas skaicius yra mazesnis uz teisinga");
        }

        int ketvirtas = Convert.ToInt32(Console.ReadLine());
        if (ketvirtas == teisingasSkacius)
        {
            Console.WriteLine("TEISINGAI");
            return;
        }
        else if (ketvirtas > teisingasSkacius)
        {
            Console.WriteLine("Ivestas skaicius yra didesnis uz teisinga");
        }
        else
        {
            Console.WriteLine("Ivestas skaicius yra mazesnis uz teisinga");
        }

        int penktas = Convert.ToInt32(Console.ReadLine());
        if (penktas == teisingasSkacius)
        {
            Console.WriteLine("TEISINGAI");
            return;
        }
        else if (penktas > teisingasSkacius)
        {
            Console.WriteLine("Ivestas skaicius yra didesnis uz teisinga");
        }
        else
        {
            Console.WriteLine("Ivestas skaicius yra mazesnis uz teisinga");
        }

        int sestas = Convert.ToInt32(Console.ReadLine());
        if (sestas == teisingasSkacius)
        {
            Console.WriteLine("TEISINGAI");
            return;
        }
        else if (sestas > teisingasSkacius)
        {
            Console.WriteLine("Ivestas skaicius yra didesnis uz teisinga");
        }
        else
        {
            Console.WriteLine("Ivestas skaicius yra mazesnis uz teisinga");
        }
    }

    public void skaiciutuvasSwitch()
    {
        /** SKAIČIUOTUVAS *
        Paprašykite naudotojo įvesti du skaičius ir matematinę operaciją ( +, -, * arba / )
        - Parašykite programą kuri į ekraną išves skaičių rezultatą
        - naudokite if
        - naudokite switch*/
        Console.WriteLine("Iveskite du skaicius");
        int pirmas = Convert.ToInt32(Console.ReadLine());
        int antras = Convert.ToInt32(Console.ReadLine());
        int rezultatas;
        Console.WriteLine("Kokia operacija noretumete atlikti(+ - / *)");
        char operatorius = Convert.ToChar(Console.Read());
        switch (operatorius)
        {
            case '+':
                rezultatas = pirmas + antras;
                Console.WriteLine($"{pirmas} {operatorius} {antras} = {rezultatas}");
                break;
            case '-':
                rezultatas = pirmas - antras;
                Console.WriteLine($"{pirmas} {operatorius} {antras} = {rezultatas}");
                break;
            case '/':
                rezultatas = pirmas / antras;
                Console.WriteLine($"{pirmas} {operatorius} {antras} = {rezultatas}");
                break;
            case '*':
                rezultatas = pirmas * antras;
                Console.WriteLine($"{pirmas} {operatorius} {antras} = {rezultatas}");
                break;
        }
    }

    public void trysDraugai()
    {
        /** Trys draugai *
        - Sukurti metodą, kuris paprašytų vartotojo įvesti tris jo draugų vardus bei kiekvieno amžių.
        - Nuskaičius duomenis atskirose eilutėse atspausdinti draugo vardą ir amžių.
        - Atspausdinti draugų amžiaus vidurkį
        - Surasti ir atspausdinti jauniausią draugą (vardą ir amžių).
        - Surasti ir atspausdinti vyriausią draugą (vardą ir amžių).
        <Hint> ieškant jauniausio, seniausio naudoti if sąlygos sakinius ir naudoti tik elementus ir
        konstrukcijas kurias iki šiol išėjome.*/

        Console.WriteLine("Iveskite draugo nr1 varda");
        string vardas1 = Console.ReadLine();
        Console.WriteLine("Iveskite draugo nr1 amziu");
        int amzius1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Iveskite draugo nr2 varda");
        string vardas2 = Console.ReadLine();
        Console.WriteLine("Iveskite draugo nr2 amziu");
        int amzius2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Iveskite draugo nr3 varda");
        string vardas3 = Console.ReadLine();
        Console.WriteLine("Iveskite draugo nr2 amziu");
        int amzius3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Pirmo draugo vardas yra {vardas1} ir amzius {amzius1}");
        Console.WriteLine($"Antro draugo vardas yra {vardas2} ir amzius {amzius2}");
        Console.WriteLine($"Trecio draugo vardas yra {vardas3} ir amzius {amzius3}");

        //JAUNIAUSIAS
        if (amzius1 < amzius2 && amzius1 < amzius3)
        {
            Console.WriteLine($"Jauniausia yra {vardas1}, jo amzius {amzius1}");
        }
        else if (amzius2 < amzius1 && amzius2 < amzius3)
        {
            Console.WriteLine($"Jauniausia yra {vardas2}, jo amzius {amzius2}");
        }
        else if (amzius3 < amzius2 && amzius3 < amzius1)
        {
            Console.WriteLine($"Jauniausia yra {vardas3}, jo amzius {amzius3}");
        }

        //VYRIAUSIAS
        if (amzius1 > amzius2 && amzius1 > amzius3)
        {
            Console.WriteLine($"Vyriausias yra {vardas1}, jo amzius {amzius1}");
        }
        else if (amzius2 > amzius1 && amzius2 > amzius3)
        {
            Console.WriteLine($"Vyriausias yra {vardas2}, jo amzius {amzius2}");
        }
        else if (amzius3 > amzius2 && amzius3 > amzius1)
        {
            Console.WriteLine($"Vyriausias yra {vardas3}, jo amzius {amzius3}");
        }

    }

    public void kaleduSausainiai()
    {
        /*** Kalėdų sausainiai **
        - Paprašykite vartotojo įvesti betkokias 4 datas (tarkim 2013-12-24, 2020-12-22, 3000-12-24, 2021-03-03)
        - Parašykite programą kuri nustato ar tarp įvestų datų yra kalėdos (gruodžio 24).
        - Ir jei yra kalėdų data, išveda - "Jums priklauso nemokami kalėdiniai sausainiai"
        - Jei nėra išveda - "Palaukite kalėdų"
        Pavyzdzio atsakymas: "Jums priklauso nemokami kalėdų sausainiai"
        <Hint> metodai data.Month ir data.Day*/

        string pattern = "yyyy-MM-dd";
        DateTime kaledos = new DateTime(2002,12,24);
        bool arGausiSausainiu = false;

        Console.WriteLine("Iveskite 4 datas");
        DateTime date1 = DateTime.ParseExact(Console.ReadLine(), pattern, null);
        DateTime date2 = DateTime.ParseExact(Console.ReadLine(), pattern, null);
        DateTime date3 = DateTime.ParseExact(Console.ReadLine(), pattern, null);
        DateTime date4 = DateTime.ParseExact(Console.ReadLine(), pattern, null);

        if(date1.Month == kaledos.Month && date1.Day == kaledos.Day)
        {
            arGausiSausainiu = true;
        }
        else if (date2.Month == kaledos.Month && date2.Day == kaledos.Day)
        {
            arGausiSausainiu = true;
        }
        else if (date3.Month == kaledos.Month && date3.Day == kaledos.Day)
        {
            arGausiSausainiu = true;
        }
        else if (date4.Month == kaledos.Month && date4.Day == kaledos.Day)
        {
            arGausiSausainiu = true;
        }

        if (arGausiSausainiu)
        {
            Console.WriteLine("Jums priklauso nemokami sausainiai");
        }
        else
        {
            Console.WriteLine("Jums nepriklauso nemokami sausainiai");
        }


    }
}