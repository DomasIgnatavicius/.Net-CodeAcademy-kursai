using _05_Querying_SQLite_DB.Infrastucture.Database;

namespace _05_Querying_SQLite_DB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, QueryingSqliteDb!");

            var manageDb = new ManageDb();

            //manageDb.AddPost("CSharp",1);
            //manageDb.AddPost("Java",2);
            //manageDb.AddAuthor("Petras","Petrauskas",1);
            manageDb.getBlogs_LazyLoading();
        }
    }
}