using _04_First_SQL_DB.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_First_SQL_DB.services.Interfaces
{
    public interface IBloggingRepository
    {
        public void addPerson(Person person);
        public void addPerson(string firstName, string lastName, DateTime birthDate, double weight);
        public void addAnimal(string name, string type, DateTime birthDate);
        public void printAllPersons();
        public void printAllPersonsSorted();
        public void printAllAnimals();
        public void printAnimalsOfType(string type);
        public void printAnimalsSortedByName();
    }
}
