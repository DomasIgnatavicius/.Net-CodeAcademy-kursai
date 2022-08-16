using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Metodai.Domain.Models._7_uzduotis
{
    public class Mokykla
    {
        public string Pavadinimas { get; set; }
        public List<Mokytojas> Mokytojai { get; set; }
    }
}
