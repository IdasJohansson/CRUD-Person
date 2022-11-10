using System;
using CRUD_Person.Interfaces;

namespace CRUD_Person.Models
{
    public class DeletePerson : IDeletePerson
    {
        public void Delete()
        {
            try
            {
            var dbContext = new PersonDbContext();

            Console.WriteLine("Enter an Id to Delete a Person from DB:");
            int id = Convert.ToInt32(Console.ReadLine());

            dbContext.Person.Remove(dbContext.Person.Find(id)); 
         
            dbContext.SaveChanges();
            Console.WriteLine("Person deleted!");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Something went wrong when deleting this Person, please try again");
            }
        }
    }
}

