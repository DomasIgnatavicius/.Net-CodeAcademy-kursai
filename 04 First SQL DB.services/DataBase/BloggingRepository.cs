using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_First_SQL_DB.services.Interfaces;
using _04_First_SQL_DB.Domain.Models;

namespace _04_First_SQL_DB.services.DataBase
{
    public class BloggingRepository : IBloggingRepository
    {
        public void addAnimal(string name, string type, DateTime birthDate)
        {
            using var context = new BloggingContext();

            context.Database.EnsureCreated();
            Animal animal = new Animal
            {
                Name = name,
                Type = type,
                BirthDate = birthDate
            };

            context.Animals.Add(animal);
            context.SaveChanges();
        }

        public void addPerson(Person person)
        {
            using var context = new BloggingContext();

            context.Database.EnsureCreated();
            context.Persons.Add(person);
            context.SaveChanges(); // tai vieta, kuri igyvendina suformuota uzklausa(gali buti kad turim 100 komandu, ir jos bus atliktos tik kai savechanges)
        }

        public void addPerson(string firstName, string lastName, DateTime birthDate, double weight)
        {
            using var context = new BloggingContext();

            context.Database.EnsureCreated();
            Person person = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                Weight = weight
            };

            context.Persons.Add(person);
            context.SaveChanges();
        }

        public void printAllPersons()
        {
            using var context = new BloggingContext();
            var persons = context.Persons;

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Id} {person.FirstName} {person.LastName} {person.BirthDate} {person.Weight}");
            }
        }

        public void printAllPersonsSorted()
        {
            using var context = new BloggingContext();
            var persons = context.Persons
                .OrderBy(p => p.FirstName);

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Id} {person.FirstName} {person.LastName} {person.BirthDate} {person.Weight}");
            }
        }

        public void printAllAnimals()
        {
            using var context = new BloggingContext();
            var animals = context.Animals;

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Id} {animal.Name} {animal.Type} {animal.BirthDate}");
            }
        }
        public void printAnimalsOfType(string type)
        {
            using var context = new BloggingContext();
            var animals = context.Animals
                .Where(a => a.Type == type);

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Id} {animal.Name} {animal.Type} {animal.BirthDate}");
            }
        }
        public void printAnimalsSortedByName()
        {
            using var context = new BloggingContext();
            var animals = context.Animals
                .OrderBy(p => p.Name);

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Id} {animal.Name} {animal.Type} {animal.BirthDate}");
            }
        }
    }
}
