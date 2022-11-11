using System;
using CRUD_Person.Interfaces;

namespace CRUD_Person.Models
{
    public class UpdatePerson : IUpdatePerson
    {

        public void Update()
        {
            try
            {
                var dbContext = new PersonDbContext();
                Console.WriteLine("Enter an Id to Update Email and Phonenumber:");
                int id = Convert.ToInt32(Console.ReadLine());
                var updPerson = dbContext.Person.Find(id);

                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                updPerson.Email = email;
                Console.WriteLine("PhoneNumber: ");
                int phoneNr = Convert.ToInt32(Console.ReadLine());
                updPerson.PhoneNr = phoneNr;

                dbContext.SaveChanges();
                Console.WriteLine("Person is Updated!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Something whent wrong when updating Person, please try again.");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Press a key to return to Menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

