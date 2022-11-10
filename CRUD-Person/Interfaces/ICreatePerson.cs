using System;
using System.Threading.Tasks;
using CRUD_Person.Models; 

namespace CRUD_Person.Interfaces
{
    public interface ICreatePerson
    {
        public void Create(Person person); 
    }
}

