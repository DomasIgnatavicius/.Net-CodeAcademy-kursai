using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Querying_SQLite_DB.Domain.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Column("Id")]
        // Galima nerasyti [Key], EF(entity framework) yra pakankamai protingas, kad pats susiprastu
        public int BlogId { get; set; }

        [Column("BlogRating",Order = 2)]
        public decimal Rating { get; set; }

        [Column("BlogName",Order = 1)] // Duomenu bazeje stulpelis bus BlogName ir jis bus antroje vietoje, po BlogId
        public string Name { get; set; }

        // Navigacine property, kad siam irasui butu galima tureti daug posts
        // Virtual naudojamas, del to kad naudojam lazyLoading
        // Lazy Loading - tai budas istraukti priklausancius duomenis automatiskai. Jei nebutu reiktu rasyti papildoma komanda, pvz .include()
        public virtual List<Post> Posts { get; set; }
        public virtual IList<AuthorBlog> AuthorBlogs { get; set; } // Lazy Loading, del zodzio virtual
        
    }
}
