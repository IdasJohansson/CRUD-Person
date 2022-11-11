using System;
using CRUD_Person.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Person.Models
{
    public class UpdatePerson : IUpdatePerson
    {
        public void Update()
        {
            // Using Sql query
            try
            {
           
                Console.WriteLine("Enter Id belonging to the Person where you want to Update Email and Phonenumber:");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
       
                Console.WriteLine("PhoneNumber: ");
                int phoneNr = Convert.ToInt32(Console.ReadLine());
 
                using (var dbContext = new PersonDbContext())
                {
                    var queryString = dbContext.Database.ExecuteSqlRaw($"UPDATE Person SET Email='{email}', PhoneNr='{phoneNr}' WHERE id = '{id}'");
                    Console.WriteLine($"Person registered with Id: {id} was successfully updated.");
                }
            
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed; 
                Console.WriteLine(e.Message);
                Console.WriteLine($"Something whent wrong when updating Person, please try again.");
                Console.ResetColor(); 
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Press a key to return to Menu");
            Console.ReadKey();
            Console.Clear();
        }

        //public void Update()
        //{
        //    try
        //    {
        //        var dbContext = new PersonDbContext();
        //        Console.WriteLine("Enter an Id to Update Email and Phonenumber:");
        //        int id = Convert.ToInt32(Console.ReadLine());
        //        var updPerson = dbContext.Person.Find(id);

        //        Console.WriteLine("Email: ");
        //        string email = Console.ReadLine();
        //        updPerson.Email = email;
        //        Console.WriteLine("PhoneNumber: ");
        //        int phoneNr = Convert.ToInt32(Console.ReadLine());
        //        updPerson.PhoneNr = phoneNr;

        //        dbContext.SaveChanges();
        //        Console.WriteLine("Person is Updated!");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        Console.WriteLine($"Something whent wrong when updating Person, please try again.");
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("------------------------------");
        //    Console.WriteLine("Press a key to return to Menu");
        //    Console.ReadKey();
        //    Console.Clear();
        //}
    }
}

