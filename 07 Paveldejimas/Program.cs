namespace _07_Paveldejimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var square1 = new Square();
            Console.WriteLine($"Priskiriam keturkampiui keturis kampus: {square1.NumberOfAngles = 4}");

            var triangle1 = new Triangle();
            Console.WriteLine($"Priskiriam trikampiui tris kampus: {triangle1.NumberOfAngles}");

            Polygon square2 = new Square(); // visiskai veikia toks priskyrimas, nes square yra paveldetas is polygon. sitoje klaseje negalesime pasiekti vaikiniu prop, nes tipas yra tevinis
            //square2.AnglesInDegrees = 90 NEVEIKIA NES TIPAS YRA POLYGON O NE SQUARE, TEVAI NEPASIEKIA VAIKINIO SCOUPO
            ((Square)square2).AngleInDegrees = 90; // taip veikia, nes pacastinam i vaikine klase

            Console.WriteLine("----------------------------------");

            List<Polygon> polygons = new List<Polygon>();
            polygons.Add(square);
            polygons.Add(triangle);
            polygons.Add(square2);
            foreach (var item in polygons)
            {
                Console.WriteLine($" {item.GetType().Name} NumberOfAngles = " + item.NumberOfAngles);
                if (item is Square)
                {
                    Console.WriteLine("Size in item =" + ((Square)item).Size);
                }
                Console.WriteLine("GetPerimeter() in item =" + item.GetPerimeter());

            }
        }

        // Base class / Parent class - tai klase kuri vienija
        public class Polygon
        {
            public Polygon()
            {

            }

            public Polygon(int numberOfAngles)
            {
                NumberOfAngles = numberOfAngles;    
            }

            public int NumberOfAngles { get; set; }


            public virtual double GetPerimeter() //virtual pasako kad paveldetoje klaseje galima metoda perrašyti
            {
                return 0;
            }
        }

        public class Square : Polygon 
        {
            public Square()
            {
                NumberOfAngles = 4; // del paveldejimo numberOfAngles yra pasiekiamas Square klaseje
            }

            public Square(double size)
            {
                Size = size;
                NumberOfAngles = 4;
            }
            public int AngleInDegrees { get; set; }
            public double Size { get; set; }
        }

        public class Triangle : Polygon
        {
            public Triangle()
            {
                NumberOfAngles = 3;
            }

            public override double GetPerimeter() // overridinam tevines klases metoda
            {
                return NumberOfAngles + 10;
            }
        }


    }
}