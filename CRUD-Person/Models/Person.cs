using System;
namespace CRUD_Person.Models
{
    public class Person
    {
        private int Id;
        private string FirstName;
        private string LastName;
        private string Email;
        private int PhoneNr; 

        // Best practise att ha properties private
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string firstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string lastName
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        public int phoneNr
        {
            get { return PhoneNr;}
            set { PhoneNr = value;}
        }

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

