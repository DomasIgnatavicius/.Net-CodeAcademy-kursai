using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konstruktoriai
{
    internal class Zmogus
    {
        public Zmogus()
        {
            gimomoData = 1990;
            lytis = "nezinoma";
            masinos = new List<Masinos>();
        }
        public Zmogus(string vardas, string pavarde, int gimomoData, string lytis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            this.gimomoData = gimomoData;
            this.lytis = lytis;
        }

        public Zmogus(Zmogus zmogus) // dublikuoja i nauja obijekta, pvz kuri zmogus3 ir i arguentus irasai zmogus2, tai sukurs nauja obijekta su zmogus2 vardu pavarde gimimoData ir lytimi
        {
            Vardas = zmogus.Vardas;
            Pavarde = zmogus.Pavarde;
            gimomoData=zmogus.gimomoData;
            lytis = zmogus.lytis;
        }

        public string Vardas;
        public string Pavarde;
        public int gimomoData;
        public int asmensKodas;
        public string lytis;
        public List<Masinos> masinos;
    }
}
