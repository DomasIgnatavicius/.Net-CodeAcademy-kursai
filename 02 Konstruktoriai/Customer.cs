using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konstruktoriai
{
    internal class Customer
    {
        // Tuscio konstruktoriaus deklaracija,  iniciavimo veikmu seka, ivyksa kai sukuri instance
        public Customer() 
        {
            vardas = "Stiurtas";
        }
        public Customer(string vardas)
        {
            this.vardas = vardas; // reikia this, nes vardas property{get;set;} ir vardas parametras(Customer(string vardas)) yra vienodi, tai kad atskirtume naudojame this, jei vienas butu Vardas, o kitas vardas - nereiketu
        }
    
        public string vardas { get; set; }
    }
}
