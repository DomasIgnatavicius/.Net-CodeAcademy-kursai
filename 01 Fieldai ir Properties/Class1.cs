using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fieldai_ir_Properties
{
    internal class ManoKambarys
    {
        public string pavadinismas { get; set; }
        public double plotas { get; set; }
        public List<Durys> durys { get; set; } = new List<Durys>();
        public List<Langai> langai { get; set; } = new List<Langai>();
        public Lova lova { get; set; } = new Lova();
    }
}
