using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Querying_SQLite_DB.Domain.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string? Content { get; set; }

        // one to many relationship
        public int BlogId { get; set; } // fizinis relationship property
        public virtual Blog Blog { get; set; } // navigacinis relationship property( naudojams naviguoti kode tarp blog properties)


    }
}
