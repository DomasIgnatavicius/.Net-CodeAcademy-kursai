using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Querying_SQLite_DB.Domain.Models
{
    public class AuthorBlog
    {
        // Many to Many relationship
        public int AuthorId { get; set; }
        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }
        public virtual Author Author { get; set; }
    }
}
