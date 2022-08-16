namespace _04_Enumerations
{
    internal class Program
    {
        static void Main(string[] args)
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
