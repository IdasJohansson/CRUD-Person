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

        string connString = "String is supposed to be hidden";

        // In the OnConfiguring() method, an instance of DbContextOptionsBuilder is used to specify which database to use. 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connString);
        }
        

    }
}

