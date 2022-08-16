using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konstruktoriai
{
    //* public: Tipą ar narį galima pasiekti naudojant bet kurį kitą kodą tame pačiame assembly kode ar kitame assembly, kuris jį referuoja.
    //* private: Tipą ar narį galima pasiekti tik pagal kodą toje pačioje klasėje ar struktūroje.
    //* internal: Tipą ar narį galima pasiekti naudojant bet kurį kodą tame pačiame assembly kode, bet ne iš kito assembly kodo.
    //* protected: tipą arba narį galima pasiekti tik pagal kodą toje pačioje klasėje arba klasėje, kuri yra išvesta iš tos klasės(Paveldėta).
    internal class PrieinamumoPVZAccessabilitycs
    {
        public PrieinamumoPVZAccessabilitycs(string pavarde)
        {
            this.Pavarde = pavarde; // taip apeiname private modifiery ir galime is isores irasyti pavardes reiksme
        }
        public string vardas;
        private string pavarde; // galima prieiti tik klaseje

        public string Pavarde { get; private set; } // naudodami property galime pasidaryti private setteri ir public getteri, taip irasyti reiksme galesime tik per konstruktoriu, o gettinti reiksme is isores
    }
}
