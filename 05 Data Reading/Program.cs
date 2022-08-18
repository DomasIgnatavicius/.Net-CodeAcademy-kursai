using _05_Data_Reading.Domain.Models;
using _04_Enumerations.Domain.Models;
using _05_Data_Reading.InitialData;
namespace _05_Data_Reading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void SakninioFolderioSuradimas(string path)
        {
            //string rootDirectoryPath = new DirectoryInfo(path).Parent.Parent.FullName;
            Console.WriteLine($"Sakninis katalogas yra {path}");
        }

        public static void SkaitymasIsIvesties()
        {
            int userColumnCount = 2;
            Console.WriteLine("Suveskite vartotojus tokiu formatu: 1, Antanas; 2, Ieva");
            string[] usersInText = Console.ReadLine()
                .Replace(" ", "") // Istriname tarpus visame stringe
                .Split(';'); // Atskiriame pagal eilutes

            List<User> users = new List<User>();

            foreach (string user in usersInText)
            {
                string[] userData = user.Split(',');

                if (userData.Length < userColumnCount) break;

                User newUser = new User(Convert.ToInt32(userData[0]), userData[1]);
                users.Add(newUser);
            }

            Console.WriteLine("Aplikacijoje turime siuos vartotojus:");
            foreach (User user in users)
            {
                Console.WriteLine($"{user.Name} ID: {user.Id}");
            }

            string naudotojoIvestis;

            Console.WriteLine("Suveskite vartotojus tokiu formatu: 1, Antanas");

            while ((naudotojoIvestis = Console.ReadLine()) != "")
            {
                Console.WriteLine("Pridedame nauja vartotoja..");
                string[] userData = naudotojoIvestis.Split(',');

                if (userData.Length < userColumnCount) break;

                User newUser = new User(Convert.ToInt32(userData[0]), userData[1]);
                users.Add(newUser);
            }

            Console.WriteLine("Aplikacijoje turime siuos vartotojus:");
            foreach (User user in users)
            {
                Console.WriteLine($"{user.Name} ID: {user.Id}");
            }
        }

        public static void SkaitymasIsStaticKlases()
        {
            List<Person> people = PersonInitialData.DataSeed.ToList();

            Console.WriteLine("Skaitant is Static Klases radome siuos zmones:");
            foreach (Person person in people)
            {
                Console.WriteLine($"Vardas Pavarde: {person.FirstName} {person.LastName}");
            }
        }
    }
}