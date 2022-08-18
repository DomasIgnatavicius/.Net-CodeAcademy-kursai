namespace _04_Enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uzduotis2();
        }

        //1 Uzduotis
        private static void Uzduotis1()
        {
            /*Sukurkite enum EGenderType su reikšmėmis 0 - MALE, 1 - FEMALE*/
        }
        internal enum EGenderType { Male, Female }

        //2 Uzduotis
        private static void Uzduotis2()
        {
            /*Sukurkite klasę Person su properčiais:
            -Id(int), 
            -FirstName(string), 
            -LastName(string), 
            -FullName(readonly string -generuojamas iš FirstName ir LastName)
            -Gender(int - užpildomas tik inicializuojant klasę reikšme arba per metodą iš enumo EGenderType)
            - BirthDate(DateTime - gali būtu null)
            - Height(Decimal)
            - Weight(Decimal)
            - Age(readonly int -gali būti null.Generuojamas iš gimimo datos(BirthDate).Generavimui naudoti metodą) 
            -NameChanges(string - įrašomas tik iš vidaus.Pildomas pakeitus FirstName arba LastName.
              Saugomi visi pakeitimai csv formatu "senas,naujas")
            */

            //---------Enumerations.Domain.Models => Person


        }

        //3 Uzduotis
        private static void Uzduotis3()
        {
            /*Sukurkite klasę Society
         1 - Sukurkite propertį People(List of persons)
         2 - sukurkite metodą FillPeople kuris užpildys sąrašą iš klasės PersonInitialData.
         3 - Sukurkite propertį OldPeople. Grąžinkite visus asmenis kurie gimė prieš 2001m. (unit - test)
         4 - Sukurkite properčius Men ir Women. 
         5 - Sukurkite metodus FillMen ir FillWomen, kurie iš PersonInitialData surašys vyrus ir moteris(unit-test) 
         6 - sukurkite metodą SortByAge(), kuris Men ir Women sąrašus esančius asmenis surikiuotu pagal amžių nuo jauniausio iki vyriausio.
         7 - Padarykite metodą kuris People, Men ir Women properčiuose esančius asmenis  rikiuos nuo A iki Z arba nuo Z iki A. 
            Pagal Vardą arba Pavardę
              tokiu principu: SortByFirstName().Asc()
                              SortByLastName().Asc()
                              SortByLastName().Desc()
            < hint > return this*/
        }







        private static void EnumsTeorija()
        {
            Console.WriteLine("Hello, Enums!\n");
            int sunday = 1;
            int monday = 2;
            int tuesday = 3;
            int wednesday = 4;
            int thursday = 5;
            int friday = 6;
            int saturday = 7;

            int dayOfWeek = friday;
            //-----------------------------

            EDaysOfWeek today = EDaysOfWeek.Tuesday;
            Console.WriteLine($"Today is {today}");
            int todayInt = (int)EDaysOfWeek.Tuesday;
            Console.WriteLine($"TodayInt is {todayInt}");

            int todayNumber = 2;
            EDaysOfWeek today1 = (EDaysOfWeek)todayNumber;
            Console.WriteLine($"Today1 is {today1}");
            //-------------------------------------
            //statines klases enumeracijos - siek tiek geriau, nes programa tampa labiau modifikuojama ir gali plestis

            int today3 = DayOfWeekEnum.Tuesday; // toks pat panaudojimas kaip enum, tik cia yra static klase - atsiranda galimybe siek tiek praplesti funkcionaluma, o sintakse visiskai nesikeicia
        }
    }
}

public enum EDaysOfWeek { Snday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday}

public static class DayOfWeekEnum 
{
    public static int Sunday = 1;
    public static int Monday = 2;
    public static int Tuesday = 3;
    public static int Wednesday = 4;
    public static int Thursday = 5;
    public static int Friday = 6;
    public static int Saturday = 7;
}

//--------------------------GERIAUSIAS VARIANTAS-------------------------------
public class CustomEnum
{
    public CustomEnum(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
    public int id { get; set; }
    public string name { get; set; }
    public override string ToString() => name;
}

public class DayOfWeekCustomEnum
{
    public static CustomEnum Sunday => new CustomEnum(1, nameof(Sunday));
    public static CustomEnum Monay => new CustomEnum(1, nameof(Monay));
    public static CustomEnum Tuesday => new CustomEnum(1, nameof(Tuesday));
    public static CustomEnum Wednesday => new CustomEnum(1, nameof(Wednesday));
    public static CustomEnum Thursday => new CustomEnum(1, nameof(Thursday));
    public static CustomEnum Friday => new CustomEnum(1, nameof(Friday));
    public static CustomEnum Saturday => new CustomEnum(1, nameof(Saturday));
}
