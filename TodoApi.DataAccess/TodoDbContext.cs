using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApi.Model;
using TodoApi.Models;

namespace TodoApi.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server = localhost\\sqlexpress; database = myTodosDb; trusted_connection = true";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author { Id = 1, FullName = "John Doe", AddressNo = "No. 100/A", Street = "Street 01", City = "Colombo 01", JobRole = "Developer"},
                new Author { Id = 2, FullName = "Willim Max", AddressNo = "No. 101/B", Street = "Street 02", City = "Colombo 02", JobRole = "System Engineer"},
                new Author{ Id = 3, FullName = "Charith Roshan", AddressNo = "No. 102/C", Street = "Street 03", City = "Colombo 03", JobRole = "Developer"},
                new Author{Id = 4, FullName = "Allon Mark ", AddressNo = "No. 103/D", Street = "Street 04", City = "Colombo 04", JobRole = "QA"}
            });

            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
                new Todo
                {
                    Id = 1,
                    Title = "Learn C#",
                    Description = "Learn C# from tutorial",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 1
                },

                new Todo
                {
                    Id = 2,
                    Title = "Learn bootstrap",
                    Description = "Learn bootstrap from tutorial",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(7),
                    Status = TodoStatus.New,
                    AuthorId = 1
                },

                new Todo
                {
                    Id = 3,
                    Title = "Learn Anguler",
                    Description = "Learn Anguler from tutorial",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(3),
                    Status = TodoStatus.New,
                    AuthorId = 2

                }

            });
        }
    }
}
