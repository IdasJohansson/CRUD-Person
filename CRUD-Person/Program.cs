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
            Console.WriteLine();
            Console.WriteLine("Hello World! Lets CRUD a Person connected to PersonDB");
            Console.WriteLine("What do you want to do? Press one of below numbers to proceed:");
            Console.WriteLine();
            Console.WriteLine("1: Create Person");
            Console.WriteLine("2: Read Person");
            Console.WriteLine("3: Update Person");
            Console.WriteLine("4: Delete Person");
            Console.WriteLine("5: View all existing Persons in PersonDB");
            Console.WriteLine("0: Exit application...");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (input)
            {
                case 1:
                    Person newPerson = new Person() {};
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
                    UpdatePerson personToUpdate = new UpdatePerson();
                    personToUpdate.Update();
                    Meny();
                    break;
                case 4:
                    DeletePerson personToDelete = new DeletePerson();
                    personToDelete.Delete();
                    Meny();
                    break;
                case 5:
                    ReadPerson getAll = new ReadPerson();
                    getAll.GetAllPersons();
                    Meny();
                    break; 
                case 0:
                    Console.WriteLine("Have a great day, press any key to exit...");
                    Console.ReadKey(); 
                    break;
                default:
                    Console.WriteLine("Wrong input...Please try again :)");
                    Console.Clear(); 
                    Meny();
                    break;
            };

            }


        }
       
    }
}

