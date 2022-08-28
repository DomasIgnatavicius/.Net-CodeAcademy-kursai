namespace _07_Paveldejimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

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
        }
    }
}