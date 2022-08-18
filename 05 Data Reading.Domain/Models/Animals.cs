using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Data_Reading.Domain.Models
{
    public class Animals
    {
        public Animals() { }
        public Animals(string[] animalData)
        {
            Id = Convert.ToInt32(animalData[0]);
            Name = animalData[1];
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
