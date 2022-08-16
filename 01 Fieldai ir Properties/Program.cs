namespace _01_Fieldai_ir_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fieldai visada buna private ir mes naudojam properties, kad apsaugotume fieldus, pvz turim class Schedule ir jamee fielda _month, ji galesime pasikti tik class viduje,
            // jei sukurtume class instace( var naujas = new Schedule() ) jame negalesime pasiekti _month( naujs._month NEVEIKS). Jeigu norime pasiekti month turime,
            // sukurti jam property Month, kurioje pvz galesime apsaugoti, kad neivestu netinkamo menesio skaiciaus(25).

        }

        private class Schedule
        {
            private int _month;

            public int Day { get; set; }

            // FIELDAI buna private, properties leidzia kontroliuoti ka nori irasyti i fielda is isores ir leidzia fieldui actinti kaip variable
            public int Month 
            { 
                get { return _month; }
                set { 
                    if((value < 0) || (value > 12))
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                         _month = value;
                    }
                }
            }
        }
    }

}