using System;
namespace CRUD_Person.Models
{
    public class Person
    {
        public int Id { get; set;}
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Email { get; set; }
        public int PhoneNr { get; set; }

        public Person()
        {

        }

        public Person(int id, string firstName, string lastName, string email, int phoneNr)
        {
            id = this.Id;
            firstName = this.FirstName;
            lastName = this.LastName;
            email = this.Email;
            phoneNr = this.PhoneNr; 
        }
        
    }
}

