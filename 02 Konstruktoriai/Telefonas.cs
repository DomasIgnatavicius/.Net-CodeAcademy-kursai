using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konstruktoriai
{
    internal class Telefonas
    {
        public Telefonas()
        {
            aspectRatio = "nenurodyta";
            modelis = "nenurodyta";
            gamintojas = "nenurodyta";
        }
        public Telefonas(string gamintojas, string modelis, int istrizaine, int isleidimoMetai, int kaina)
        {
            this.gamintojas = gamintojas;
            this.modelis = modelis;
            this.istrizaine = istrizaine;
            this.isleidimoMetai = isleidimoMetai;
            this.kaina = kaina;
        }
        //tarp : this() skliaustu galima irasyti antro konstruktoriaus parametrus(this("apple", "iphone" ...)) ir tada bus iskviestas antras konstruktorius
        public Telefonas(Telefonas telefonas) : this() // tas zodelis this pirma pakviecia tuscia konstruktoriu(pati pirma), ir tik tada pakviecia kopijavimo konstruktoriu, taip yra suchaininami konstruktoriai
        {
            aspectRatio = telefonas.aspectRatio;
            gamintojas = telefonas.gamintojas;
            modelis = telefonas.modelis;
            procesoriaus = telefonas.procesoriaus;
        }
        public string gamintojas;
        public string modelis;
        public string procesoriaus;
        public string operacijaSistema;
        public string aspectRatio;
        public int baterijosTalpa;
        public int istrizaine;
        public int rezoliucija;
        public int isleidimoMetai;
        public int kaina;
    }
}
