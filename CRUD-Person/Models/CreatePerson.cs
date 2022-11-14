using System;
using System.Threading.Tasks;
using CRUD_Person.Models;
using CRUD_Person.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Person.Models
{
    public class CreatePerson : ICreatePerson
    {

        public void Create(Person person)
        {
            // Using Sqlquery
            try
            {
            Console.WriteLine("Insert an Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert your First name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Insert your Last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Insert your Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Insert your PhoneNr:");
            int phoneNr = Convert.ToInt32(Console.ReadLine());

            Person newPerson = new Person()
            {
                id = id,
                firstName = firstName,
                lastName = lastName,
                email = email,
                phoneNr = phoneNr
            };

            using (var dbContext = new PersonDbContext())
            {
                int queryString = dbContext.Database.ExecuteSqlRaw($"INSERT INTO Person(Id, FirstName, LastName, Email, PhoneNr) VALUES('{id}', '{firstName}', '{lastName}', '{email}', '{phoneNr}')"); 
            }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen; 
                Console.WriteLine("Person was successfully created!");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.WriteLine("Something went wrong when creating a new Person. Please try again");
                Console.ResetColor(); 
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Press a key to return to Menu");
            Console.ReadKey();
            Console.Clear();
        }

        //public void Create(Person person)
        //{
        //    try
        //    {
        //    Console.WriteLine("Insert an Id");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Insert your First name:");
        //    string firstName = Console.ReadLine();
        //    Console.WriteLine("Insert your Last name:");
        //    string lastName = Console.ReadLine();
        //    Console.WriteLine("Insert your Email:");
        //    string email = Console.ReadLine();
        //    Console.WriteLine("Insert your PhoneNr:");
        //    int phoneNr = Convert.ToInt32(Console.ReadLine());

        //    var dbContext = new PersonDbContext();

        //    Person newPerson = new Person()
        //    {
        //        Id = id,
        //        FirstName = firstName,
        //        LastName = lastName,
        //        Email = email,
        //        PhoneNr = phoneNr
        //    };

        //    dbContext.Person.Add(newPerson);
        //    dbContext.SaveChanges();

        //    Console.WriteLine("Person created!");

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        Console.WriteLine("Something went wrong when creating a new Person. Please try again");
        //    }
        //    Console.WriteLine("------------------------------");
        //    Console.WriteLine("Press a key to return to Menu");
        //    Console.ReadKey();
        //    Console.Clear();
        //}

    }
}

