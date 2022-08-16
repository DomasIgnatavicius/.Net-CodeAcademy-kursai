using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Metodai.Domain.Models
{
    public class Namas
    {
        public Namas()
        {
            yraDarzas = false;
            _zmoniuVardai = new List<string>();
            Zmones = new List<Zmogus>() 
            { 
                new Zmogus(){ vardas = "Petras"},
                new Zmogus(){ vardas = "Ieva"},
                new Zmogus(){ vardas = "Jonas"},
            };

            foreach (var zmogus in Zmones)
            {
                zmoniuVardai.Add(zmogus.vardas);
            }
        }
        private Namas(string adresas) : this()
        {
            this.adresas = adresas;
        }
        internal Namas(int kambariuSkaicius): this()
        {
            this.kambariuSkaicius = kambariuSkaicius;
        }
        public Namas(int kambariuSkaicius, string adresas) : this(adresas)
        {
            this.kambariuSkaicius = kambariuSkaicius;
        }
        

        internal List<Zmogus> Zmones { get; set; }


        private List<string> _zmoniuVardai;
        public List<string> zmoniuVardai
        {
            get { return _zmoniuVardai; }
            set { _zmoniuVardai = value; }
        }
        public int kambariuSkaicius { get; private set; }
        public string adresas { get; set; }
        public bool yraDarzas { get; internal set; }

    }
}
