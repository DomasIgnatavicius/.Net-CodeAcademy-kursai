using _03_Linq_Query.Models;

namespace _03_Linq_Query
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Linq Query");

            List<Person> Students = new List<Person>
            {
                new Person{ Id = 1, Name = "John", Age = 18, ProffesionId = 1},
                new Person{ Id = 2, Name = "Steve", Age = 21, ProffesionId = 2},
                new Person{ Id = 3, Name = "Bill", Age = 17, ProffesionId = 2},
                new Person{ Id = 4, Name = "Rean", Age = 21, ProffesionId = 1},
                new Person{ Id = 5, Name = "Rom", Age = 24},
                new Person{ Id = 6, Name = "Bill", Age = 27, ProffesionId = 3}
            };

            List<Profession> Proffesions = new List<Profession>
            {
                new Profession{ ProffesionId = 1, TextLt = "Mokytojas"},
                new Profession{ ProffesionId = 2, TextLt = "Daktaras"},
                new Profession{ ProffesionId = 3, TextLt = "Programuotojas"},
            };

            List<Hobby> Hobbies = new List<Hobby>
            {
                new Hobby { HobbyId = 1, TextLt = "Daile"},
                new Hobby { HobbyId = 2, TextLt = "Muzika"},
                new Hobby { HobbyId = 3, TextLt = "Sokis"},
                new Hobby { HobbyId = 4, TextLt = "Programavimas"},
            };



            // Filtruojame studentus, kuriem yra maziua nei 20 metu
            var jauniStudentai = from s in Students
                                 where s.Age < 20
                                 select s;
            // Linq veikia tik tada kai yra isvedamas i ekrana arba kvieciame toList(), kitaip linq neatliks save veiksmu
            // 1
            jauniStudentai.ToList();
            // 2
            foreach (var jaunasStudentas in jauniStudentai)
            {
                Console.WriteLine(" " + jaunasStudentas.Name);
            }
            Console.WriteLine("-------------------------------------------------------------------");




            // Studentu rikiavimas pagal amziu ir/arba varda
            var surikiuotiStudentai = from s in Students // pagal amziu didejimo
                                      orderby s.Age
                                      select s;

            var surikiuotiStudentaiDescendins = from s in Students // pagal amziu mazejimo
                                                orderby s.Age descending
                                                select s;

            var surikiuotiStudentaiVardasAmzius = from s in Students // pagal amziu didejimo ir tada pagal varda didejimo(jeigu amzius sutaps, bus pagal abc surikiuota)
                                                  orderby s.Age, s.Name
                                                  select s;

            Console.WriteLine("Ascending");
            foreach (var s in surikiuotiStudentai)
            {
                Console.WriteLine(" " + s.Name);
            }
            Console.WriteLine("Descending");
            foreach (var s in surikiuotiStudentaiDescendins)
            {
                Console.WriteLine(" " + s.Name);
            }
            Console.WriteLine("Pagal amziu ir varda");
            foreach (var s in surikiuotiStudentaiVardasAmzius)
            {
                Console.WriteLine(" " + s.Name);
            }
            Console.WriteLine("-------------------------------------------------------------------");




            //Is student paselektinam studenta ir idedam ji i nauja obijekta, bet paselectinam tik name ir age
            var studentai = from s in Students
                            select new SudentDto
                            {
                                Name = "Mr. " + s.Name,
                                Age = s.Age,
                            };
            // naudojama ANONIMINE KLASE (naudojama laikinai, greitam panaudojimui) 
            var studentai1 = from s in Students // nebutina kurti naujos klases, visa paselectinta data galima deti tiesiai i kintamaji
                             select new
                             {
                                 Name = "Mr. " + s.Name,
                                 Age = s.Age,
                             };

            // tas pats tik su LINQ EXTENSIONS
            var studentai2 = Students.Select(s => new SudentDto { Name = "Mr. " + s.Name, Age = s.Age });
            var studentai3 = Students.Select(s => new { Name = "Mr. " + s.Name, Age = s.Age });
            Console.WriteLine("Su klase");
            foreach (var s in studentai)
            {
                Console.WriteLine(" " + s.Name + " " + s.Age);
            }
            Console.WriteLine("Be klases");
            foreach (var s in studentai1)
            {
                Console.WriteLine(" " + s.Name + " " + s.Age);
            }
            Console.WriteLine("-------------------------------------------------------------------");



            // GALIMA NAUDOTI TIK SU EXTENSION, QUERY NETURI
            bool arYraStudentu16metu = Students.Any(s => s.Age == 16);

            var avgAmzius = Students.Average(s => s.Age);

            var totalStudents = Students.Count(s => s.Age >= 18); // kiek yra sudentu, kuriems 18 ir daugiau

            var totalStudent2 = (from s in Students //  QUERY IR EXTENSION GALIMA MAISYTI
                                 where s.Age >= 18 // su query tik prafiltruojam
                                 select s).Count(); // sumaisom su extension, kuris turi count()

            var distinctStudents1 = Students.Distinct();

            var distinctStudents2 = (from s in Students // vel sumaisom sintaxes 
                                     select s).Distinct();




            // JOINING
            Console.WriteLine("Keliu kolekciju sujungimas");
            var innerJoin = from s in Students
                            join p in Proffesions on s.ProffesionId equals p.ProffesionId
                            select new // is vienos kolekcijos paemem varda, is kito profesijos pavadinima
                            {
                                StudentName = s.Name,
                                StudentProffesion = p.TextLt
                            };
            foreach (var s in innerJoin)
            {
                Console.WriteLine(" " + s.StudentName + " " + s.StudentProffesion);
            }
            Console.WriteLine("-------------------------------------------------------------------");





            // GRUPAVIMAS
            Console.WriteLine("Grupavimas");
            var sugrupuotiStudentai = from s in Students
                                      group s by s.Age;
            foreach (var amziausGrupe in sugrupuotiStudentai) // sitas loopina per grupes
            {
                Console.WriteLine($"Amzius {amziausGrupe.Key}");
                foreach (var studentas in amziausGrupe) // sitas loopina per vienos grupes obijektus
                {
                    Console.WriteLine($"    Studentas yra: {studentas.Name}");
                }
            }
            Console.WriteLine("-------------------------------------------------------------------");






            //NESTING COMPOSITION 1:1
            Console.WriteLine("Kompozicija 1:1");
            var studentasIrProfesija = from s in Students
                                       select new
                                       {
                                           Student = s,
                                           Proffesion = (from pr in Proffesions
                                                         where pr.ProffesionId == s.ProffesionId
                                                         select pr).FirstOrDefault()
                                        };
            foreach (var s in studentasIrProfesija)
            {
                Console.WriteLine(" " + s.Student.Name + " " + s.Proffesion?.TextLt);
            }
            Console.WriteLine("-------------------------------------------------------------------");






            //NESTING COMPOSITION 1:M PVZ. parinti studentam po 2 hobius
            Console.WriteLine("Kompozicija 1:M (one to many)");
            var studentasIrHobis = from s in Students
                                       select new
                                       {
                                           Student = s,
                                           Hobbies = Hobbies.Take(2)
                                       };
            foreach (var studentas in studentasIrHobis)
            {
                Console.WriteLine($"Studentas {studentas.Student.Name} turi hobius: ");
                foreach (var hobis in studentas.Hobbies)
                {
                    Console.WriteLine($"    {hobis.TextLt}");
                }
            }
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("UZDUOTYS");
            Console.WriteLine();

            Console.WriteLine("Pirma: uzklausa, kuri is masyvo grazina lyginius sk");
            pirmaUzduotis();
            Console.WriteLine("Antra: uzklausa, kuri is masyvo grazina teigiamus sk");
            antraUzduotis();
            Console.WriteLine("Trecia: uzklausa, kuri is masyvo grazina skaiciu kvadrata");
            treciaUzduotis();
            Console.WriteLine("Ketvirta: uzklausa, kuri is masyvo grazina skaiciaus pasikartojimu kieki");
            treciaUzduotis();

        }

        public static int[] pirmaUzduotis()
        {
            int[] skaiciai = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var lyginiai = (from s in skaiciai
                           where s % 2 == 0
                           select s).ToArray();

            foreach (var s in lyginiai)
            {
                Console.WriteLine(s);
            }
            return lyginiai;
        }

        public static int[] antraUzduotis()
        {
            int[] skaiciai = new int[] { 1,3,-2,-4,-7,-3,-8,12,19,6,9,10,14 };

            var neigiami = (from s in skaiciai
                            where s < 0
                            select s).ToArray();

            foreach (var s in neigiami)
            {
                Console.WriteLine(s);
            }
            return neigiami;
        }
        public static int[] treciaUzduotis()
        {
            int[] skaiciai = new int[] {3,9,2,8,6,5};

            var skaiciuasKvadratas = (from s in skaiciai
                            select s*s).ToArray();

            foreach (var s in skaiciuasKvadratas)
            {
                Console.WriteLine(s);
            }
            return skaiciuasKvadratas;
        }
        public static int[] ketvirtaUzduotis()
        {
            int[] skaiciai = new int[] {3,9,2,8,6,5,5,9,1,2,3,7,5,6,7,3,7,6,8,5,4,9,6,2};

            var pasikartojimuKiekis = (from s in skaiciai
                                      where s < 0
                                      select s * s).ToArray();

            foreach (var s in pasikartojimuKiekis)
            {
                Console.WriteLine(s);
            }
            return pasikartojimuKiekis;
        }




    }
}