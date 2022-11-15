using System;
using CRUD_Person.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Person.Models
{
    public class DeletePerson : IDeletePerson
    {
        // Using Sql query
        public void Delete()
        {
            try
            {
                Console.WriteLine("Enter an Id to Delete a Person from DB:");
                int id = Convert.ToInt32(Console.ReadLine());
                using (var dbContext = new PersonDbContext())
                {
                    var queryString = dbContext.Database.ExecuteSqlRaw($"DELETE FROM Person WHERE id = '{id}'");
                    Console.WriteLine($"Person registered with Id: {id} was successfully deleted.");
                }
            }
            catch (Exception e)
            {
                Helper redText = new Helper();
                redText.TextColor(e.Message);
                redText.TextColor("Something went wrong when deleting this Person, please try again");
            }
            Helper message = new Helper();
            message.ReturnMenuMessage();
        }

        //public void Delete()
        //{
        //    try
        //    {
        //        var dbContext = new PersonDbContext();

        //        Console.WriteLine("Enter an Id to Delete a Person from DB:");
        //        int id = Convert.ToInt32(Console.ReadLine());

        //        dbContext.Person.Remove(dbContext.Person.Find(id));

        //        dbContext.SaveChanges();
        //        Console.WriteLine("Person deleted!");

        //    }
        //    catch (Exception e)
        //    {
        //        Console.ForegroundColor = ConsoleColor.DarkRed;
        //        Console.WriteLine(e.Message);
        //        Console.WriteLine("Something went wrong when deleting this Person, please try again");
        //        Console.ResetColor();
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("------------------------------");
        //    Console.WriteLine("Press a key to return to Menu");
        //    Console.ReadKey();
        //    Console.Clear();
        //}
    }
}

