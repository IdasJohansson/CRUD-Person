using System;
using System.Text;
using CRUD_Person.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CRUD_Person
{
    class Program
    {
        static void Main(string[] args)
        {

            // This is an exercise in CRUD functions

            // Create a Console Application containing: 
            // Create methods for CRUD
            // Create Person
            // Read Person
            // Update Person
            // Delete Person

            // Create connection string
            // Use DB context

            // Create Interfaces for all CRUD classes
            Meny();

            void Meny()
            {
                try
                {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"\n ██████╗██████╗ ██╗   ██╗██████╗ \n██╔════╝██╔══██╗██║   ██║██╔══██╗\n██║     ██████╔╝██║   ██║██║  ██║\n██║     ██╔══██╗██║   ██║██║  ██║\n╚██████╗██║  ██║╚██████╔╝██████╔╝\n ╚═════╝╚═╝  ╚═╝ ╚═════╝ ╚═════╝ \n                                 \n");
                Console.ResetColor();
                Console.WriteLine("Hello World! Lets CRUD a Person connected to PersonDB.");
                Console.WriteLine("What do you want to do? Press one of below numbers to proceed:");
                Console.WriteLine();
                Console.WriteLine("1: Add new Person to DB");
                Console.WriteLine("2: Get Person by Id");
                Console.WriteLine("3: Get all Persons in DB");
                Console.WriteLine("4: Update Email & Phone NR ");
                Console.WriteLine("5: Delete Person");
                Console.WriteLine("0: Exit application...");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (input)
                {
                    case 1:
                        Person newPerson = new Person() { };
                        CreatePerson addPerson = new CreatePerson();
                        addPerson.Create(newPerson);
                        Meny();
                        break;
                    case 2:
                        ReadPerson getPerson = new ReadPerson();
                        getPerson.Read();
                        Meny();
                        break;
                    case 3:
                        ReadPerson getAll = new ReadPerson();
                        getAll.GetAllPersons();
                        Meny();
                        break;
                    case 4:
                        UpdatePerson personToUpdate = new UpdatePerson();
                        personToUpdate.Update();
                        Meny();
                        break;
                    case 5:
                        DeletePerson personToDelete = new DeletePerson();
                        personToDelete.Delete();
                        Meny();
                        break;
                    case 0:
                        Console.WriteLine("Have a great day, press any key to exit...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Wrong input...Press a key and try again :)");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        Meny();
                        break;
                };
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Only numbers between 0-5 allow as input. Try again");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    Meny();
                }

            }


        }

    }
}

