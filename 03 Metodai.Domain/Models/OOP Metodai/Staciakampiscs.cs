using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Metodai.Domain.Models.OOP_Metodai
{
    public class Staciakampiscs
    {
        public Staciakampiscs(double ilgis, double plotis)
        {
            this.ilgis = ilgis;
            this.plotis = plotis;
        }



        public double ilgis { get; private set; }
        public double plotis { get; private set; }




        public double ApskaiciuotiPlota() // naudojama non static metoda, kad galetume dirbti su individualiu obijektu
        {
            // Nereikia nieko paduoti, nes naudojame klases properties
            return plotis * ilgis;
        }

        public void pakeistiIlgi(double ilgis) // galime keisti private setteri
        {
            this.ilgis = ilgis;
        }public void pakeistiPloti(double plotis) // galime keisti private setteri
        {
            this.plotis = plotis;
        }
    }
}
