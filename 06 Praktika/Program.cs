using P038_Praktika.Models;

namespace _06_Praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Praktika!");

            /*
             1 - Sukurkite klase Hobby su properčiais
                   -Id
                   - Text
                   - TextLt
                2 - Sukurkite konstruktorių be parametrų(pasiekiama visur)
                3 - Sukurkite konstruktorių su id, text, textLt parametrais(pasiekiama visur)
                4 - Skirtingais būdais inicializuokite  klases.Įrašykite po 3 hobius.
                5 - Hobby klasėje sukurkite metodą kuris iškoduos HobbyInitialData.DataSeedCsv vieną įrašą(string)
                   ir užpildys properčius duomenimis. unit - test
            */

            //4
            var hobby1 = new Hobby(); // nelabai geras budas, nes sukuriam tuscia obijekta, jam nera prasmes(nesvarbu, kad veliau irasom reiksmes)
            hobby1.Id = 1;
            hobby1.Text = "Art";
            hobby1.TextLt = "Menas";

            var hobby2 = new Hobby(2,"Tennis", "Tenisas"); // konstruktorius su parametrais budas

            var hobby3 = new Hobby()// object inicialization budas
            {
                Id = 3,
                Text = "Basketball", 
                TextLt = "Krepsinis"
            };
        }
    }
}