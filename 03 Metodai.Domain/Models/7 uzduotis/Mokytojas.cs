using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Metodai.Domain.Models._7_uzduotis
{
    public class Mokytojas
    {
        public string Vardas { get; set; }
        public Mokykla Mokykla { get; set; }
        public List<Studentas> Studentai { get; set; }
        public Pamoka Pamoka { get; set; }
    }
}
