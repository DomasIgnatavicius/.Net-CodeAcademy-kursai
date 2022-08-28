using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Enumerations.Domain.Enums;

namespace _04_Enumerations.Domain.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public EGenderType Gender { get;  set; }
        public DateTime? BirthDate { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public int? Age { get { return GenerateAge(); } }

        private int GenerateAge()
        {
            return DateTime.Now.Year - BirthDate.Value.Year;
        }
    }
}
