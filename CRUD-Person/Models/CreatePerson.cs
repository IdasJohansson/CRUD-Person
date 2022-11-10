using System;
using System.Threading.Tasks;
using CRUD_Person.Models;
using CRUD_Person.Interfaces; 

namespace CRUD_Person.Models
{
    public class CreatePerson : ICreatePerson
    {
        public void Create(Person person)
        {
            try
            {
            Console.WriteLine("Insert an Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert your First name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Insert your Last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Insert your Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Insert your PhoneNr:");
            int phoneNr = Convert.ToInt32(Console.ReadLine());

            var dbContext = new PersonDbContext();

            Person newPerson = new Person()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNr = phoneNr
            };

            dbContext.Person.Add(newPerson);
            dbContext.SaveChanges();

            Console.WriteLine("Person created!");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Something went wrong when creating a new Person. Please try again");
            }
        }

    }
}

