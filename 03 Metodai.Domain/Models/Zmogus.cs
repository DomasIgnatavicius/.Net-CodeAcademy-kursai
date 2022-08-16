using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Metodai.Domain.Models
{
    // Access Modifiers:
    //* public: Tipą ar narį galima pasiekti naudojant bet kurį kitą kodą tame pačiame assembly kode ar kitame assembly, kuris jį referuoja.
    //* private: Tipą ar narį galima pasiekti tik pagal kodą toje pačioje klasėje ar struktūroje.
    //* internal: Tipą ar narį galima pasiekti naudojant bet kurį kodą tame pačiame assembly kode, bet ne iš kito assembly kodo.
    //* protected: tipą arba narį galima pasiekti tik pagal kodą toje pačioje klasėje arba klasėje, kuri yra išvesta iš tos klasės(Paveldėta).
    
    internal class Zmogus
    {
        public Zmogus() // turi buti tuscias konstruktorius(tuscias tai tie skliausteliai tusti), tam kad nemestu erroru(kaip suprantu, jeigu neapsirasai nei vieno konstruktoriaus, jis susikuria by default)
        {
            
        }
        public Zmogus(int zmogausNamoKambariuSkaicius)
        {
            Namas = new Namas(zmogausNamoKambariuSkaicius)
            {
                yraDarzas = true
            };
        }
        public Zmogus(string pavarde)
        {
            this.pavarde = pavarde;
        }

        public Zmogus(string vardas, Namas namas, string pavarde) : this(vardas)
        {
            Namas = namas;
            this.vardas = vardas;
        }

        public string vardas { get; set; }
        public Namas Namas { get; set; }
        public string pavarde { get; set; }
    }
}
