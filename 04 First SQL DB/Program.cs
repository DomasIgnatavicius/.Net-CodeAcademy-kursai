using _04_First_SQL_DB.services.Interfaces;
using _04_First_SQL_DB.services.DataBase;

namespace _04_First_SQL_DB
{
    internal class Program
    {
        private static IBloggingRepository bloggingRepository = new BloggingRepository();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, SQLite!");

            // Trys budai kaip aktyvuoja duombaziu naudojima:
            // 1. DataBase first - nera kodo, kuris nurodo kaip turetu atrodyti duomenu baze
            // 2. Model first - turime schema, kuria padedam i severi ir sugeneruoja duomenu baze
            // 3. Code first - pirma pasirasom kaip turi atrodyti DB is kodo puses ir tada ja sugeneruojam pagal koda

            // Technologija komunikacijai su DB: EntityFrameworkCore

            // Pradedant naudoti SQLite turime irasyti siuos NuGet (Tools -> nugget package manager -> manage nuget package for solution)
            // 1. Microsoft.EntityFrameworkCore.Sqlite
            // 2. Microsoft.EntityFrameworkCore.Proxies
            // 3. Microsoft.EntityFrameworkCore.Tools

            while (true)
            {
                Console.WriteLine($"\n1.Add new user\n2.Add new animal\n3.Display all users\n4.Display all users ordered by name\n5.Display all animals\n6.Display animals filtered by type\n7.Display animals sorted by name\nq.Quit");
                char selection = Console.ReadKey().KeyChar;
                switch (selection)
                {
                    case '1':
                        Console.WriteLine("\nName: ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("\nLast Name: ");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("\nDirth Date(2001/01/01): ");
                        DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("\nWeight: ");
                        double weight = Convert.ToDouble(Console.ReadLine());
                        bloggingRepository.addPerson(firstName, lastName, birthDate,weight);
                        break;
                    case '2':
                        Console.WriteLine("\nName: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("\nType: ");
                        string type = Console.ReadLine();
                        Console.WriteLine("\nDirth Date(2001/01/01): ");
                        DateTime birthDateAnimal = Convert.ToDateTime(Console.ReadLine());
                        bloggingRepository.addAnimal(name, type, birthDateAnimal);
                        break;
                    case '3':
                        bloggingRepository.printAllPersons();
                        break;
                    case '4':
                        bloggingRepository.printAllPersonsSorted();
                        break;
                    case '5':
                        bloggingRepository.printAllAnimals();
                        break;
                    case '6':
                        Console.WriteLine("Type: ");
                        string animalType = Console.ReadLine();
                        bloggingRepository.printAnimalsOfType(animalType);
                        break;
                    case '7':
                        bloggingRepository.printAnimalsSortedByName();
                        break;
                    case 'q':
                        break;
                    default:
                        Console.WriteLine("Incorect input, try again");
                        break;
                }
            }
        }
    }
}