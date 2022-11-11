using System;
using System.Linq;
using CRUD_Person.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Person.Models
{
    public class ReadPerson : IReadPerson
    {
        // Using SQL queries
        public void Read()
        {
            try
            {
                Console.WriteLine("Enter an Id to get Person details:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                using (var dbContext = new PersonDbContext())
                {
                    Console.WriteLine("Person details: ");
                    Console.WriteLine();
                    var queryString = dbContext.Person.FromSqlRaw($"SELECT Id,FirstName, LastName, Email, PhoneNr FROM Person where Id = {id}").ToList();

                    foreach (var person in queryString)
                    {
                        Console.WriteLine($"Id: {person.Id}");
                        Console.WriteLine($"First Name: {person.FirstName}");
                        Console.WriteLine($"Last Name: {person.LastName}");
                        Console.WriteLine($"Email: {person.Email}");
                        Console.WriteLine($"Phone Number: {person.PhoneNr}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.WriteLine("Something went wrong when Reading Person, please try again");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Press a key to return to Menu");
            Console.ReadKey();
            Console.Clear();
        }

        public void GetAllPersons()
        {
            try
            {
                using (var dbContext = new PersonDbContext())
                {
                    var queryString = dbContext.Person.FromSqlRaw($"SELECT Id,FirstName, LastName, Email, PhoneNr FROM Person").ToList();
                    Console.WriteLine($"Numer of persons registered in PersonDB: {queryString.Count()}");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Person details: ");
                    Console.WriteLine();

                    foreach (var person in queryString)
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
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.WriteLine("Something went wrong when Reading Persons, please try again");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Press a key to return to Menu");
            Console.ReadKey();
            Console.Clear();
        }
    }

    //public void Read()
    //{
    //    try
    //    {
    //        var dbContext = new PersonDbContext();

    //        Console.WriteLine("Enter an Id to get Person details:");
    //        int id = Convert.ToInt32(Console.ReadLine());

    //        var person = dbContext.Person.Find(id);

    //        Console.WriteLine($"Id: {person.Id}");
    //        Console.WriteLine($"First Name: {person.FirstName}");
    //        Console.WriteLine($"Last Name: {person.LastName}");
    //        Console.WriteLine($"Email: {person.Email}");
    //        Console.WriteLine($"Phone Number: {person.PhoneNr}");
    //    }
    //    catch (Exception e)
    //    {
    //        Console.WriteLine(e.Message);
    //        Console.WriteLine("Something went wrong when Reading Person, please try again");
    //    }
    //    Console.WriteLine();
    //    Console.WriteLine("------------------------------");
    //    Console.WriteLine("Press a key to return to Menu");
    //    Console.ReadKey();
    //    Console.Clear();
    //}

    //public void GetAllPersons()
    //{
    //    try
    //    {
    //    var dbContext = new PersonDbContext();
    //    var listAllPersons = dbContext.Person.ToList();
    //        foreach (var person in listAllPersons)
    //        {
    //            Console.WriteLine($"Id: {person.Id}");
    //            Console.WriteLine($"First Name: {person.FirstName}");
    //            Console.WriteLine($"Last Name: {person.LastName}");
    //            Console.WriteLine($"Email: {person.Email}");
    //            Console.WriteLine($"Phone Number: {person.PhoneNr}");
    //            Console.WriteLine();
    //            Console.WriteLine("********************************");
    //            Console.WriteLine();
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        Console.ForegroundColor = ConsoleColor.DarkRed;
    //        Console.WriteLine(e.Message);
    //        Console.WriteLine("Something went wrong when Reading Persons, please try again");
    //        Console.ResetColor();
    //    }
    //    Console.WriteLine();
    //    Console.WriteLine("------------------------------");
    //    Console.WriteLine("Press a key to return to Menu");
    //    Console.ReadKey();
    //    Console.Clear();
    //}

}


