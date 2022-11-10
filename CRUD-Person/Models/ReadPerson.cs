using System;
using System.Linq;
using CRUD_Person.Interfaces;

namespace CRUD_Person.Models
{
    public class ReadPerson : IReadPerson
    {
        public void Read()
        {
            try
            {
            var dbContext = new PersonDbContext();

            Console.WriteLine("Enter an Id to get Person details:");
            int id = Convert.ToInt32(Console.ReadLine());  

            var person = dbContext.Person.Find(id);

            Console.WriteLine($"Id: {person.Id}");
            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine($"Email: {person.Email}");
            Console.WriteLine($"Phone Number: {person.PhoneNr}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Something went wrong when Reading Person, please try again");
            }
        }

        public void GetAllPersons()
        {
            try
            {
            var dbContext = new PersonDbContext();
            var listAllPersons = dbContext.Person.ToList();
            foreach (var person in listAllPersons)
            {
                Console.WriteLine($"Id: {person.Id}");
                Console.WriteLine($"First Name: {person.FirstName}");
                Console.WriteLine($"Last Name: {person.LastName}");
                Console.WriteLine($"Email: {person.Email}");
                Console.WriteLine($"Phone Number: {person.PhoneNr}");
                Console.WriteLine();
                Console.WriteLine("********************************");
                Console.WriteLine();
            }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Something went wrong when Reading Persons, please try again");
            }
        }

    }
}

