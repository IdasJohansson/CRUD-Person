using System;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Person.Models
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext()
        {
        }
   
        public DbSet<Person> Person { get; set; }

        static string server = "localhost";
        static string database = "PersonDB";
        static string userId = "sa";
        static string password = "P@ssw0rd";

        string connString = $"Server={server};Database={database};User Id={userId};Password={password};";

        // In the OnConfiguring() method, an instance of DbContextOptionsBuilder is used to specify which database to use. 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connString);
        }
        

    }
}

