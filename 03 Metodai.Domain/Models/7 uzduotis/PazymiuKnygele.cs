using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Metodai.Domain.Models._7_uzduotis
{
    public class PazymiuKnygele
    {
        public Studentas Studentas { get; set; }
        public Dictionary<Pamoka, List<int>> Pamokos { get; set; }
    }
}
