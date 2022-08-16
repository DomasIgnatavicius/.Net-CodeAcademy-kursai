using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Metodai.Domain.Models._7_uzduotis
{
    public class Pamoka
    {
        public string Pavadinimas { get; set; }
        public Mokytojas Mokytojas { get; set; }
        public PazymiuKnygele PazymiuKnygele { get; set; }
    }
}
