using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _04_First_SQL_DB.Domain.Models
{
    public class Animal
    {
        public Animal()
        {

        }
        public Animal(string name, string type, DateTime birthDate)
        {
            Name = name;
            Type = type;
            BirthDate = birthDate;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
