using _05_Querying_SQLite_DB.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Querying_SQLite_DB.Infrastucture.Database
{
    public class ManageDb
    {
        public ManageDb()
        {
            using var context = new BloggingContext();
            context.Database.EnsureCreated();
        }

        public void AddBlog(string name)
        {
            using var context = new BloggingContext();
            context.Blogs.Add(new Blog { Name = name });
            context.SaveChanges();
        }

        public void AddPost(string title, int blogId)
        {
            using var context = new BloggingContext();
            var blog = context.Blogs.Find(blogId);
            blog.Posts.Add(new Post { Title = title });
            context.SaveChanges();
        }

        public void AddAuthor(string firstName, string lastName, int blogId)
        {
            using var context = new BloggingContext();
            context.AuthorBlogs.Add(
                new AuthorBlog 
                { 
                    Author = new Author 
                    {
                        FirstName = firstName,
                        LastName = lastName
                    },
                    BlogId = blogId
                });
            context.SaveChanges();
        }

        public void getBlogs_EagerLoading()
        {
            using var context = new BloggingContext();
            var blogs = context.Blogs
                .Include(b => b.Posts); // Eager Loading yra naudojamas pridedant zodi Include() ir jo viduje nurodome navigacine property

            foreach (var blog in blogs)
            {
                Console.WriteLine($"** {blog.BlogId} {blog.Name}");
                foreach (var post in blog.Posts)
                {
                    Console.WriteLine($"- {post.PostId} {post.Title}");
                }
            }

        }

        public void getBlogs_LazyLoading()
        {
            using var context = new BloggingContext();
            var blogs = context.Blogs
                .ToList(); // Lazy Loading - automatiskai istraukia visus postus, brangi operacija

            foreach (var blog in blogs)
            {
                Console.WriteLine($"** {blog.BlogId} {blog.Name}");
                foreach (var post in blog.Posts)
                {
                    Console.WriteLine($"- {post.PostId} {post.Title}");
                }
            }

        }
    }
}
