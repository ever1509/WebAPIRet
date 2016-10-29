using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.BusinessLayer.Contracts;
using Test.Domain.EntityLayer;

namespace Test.Domain.BusinessLayer
{
    public partial class TestBusinessObject:ITestBusinessObject
    {

        public Person CreatePerson(Person entity)
        {
            UnitOfWork.PersonRepository.Add(entity);
            return entity;
        }

        public Person DeletePerson(Person entity)
        {
            UnitOfWork.PersonRepository.Remove(entity);
            return entity;
        }

        public Person GetPerson(Person entity)
        {
            return UnitOfWork.PersonRepository.Get(entity);
        }

        public IEnumerable<Person> GetPersons()
        {
            return UnitOfWork.PersonRepository.GetAll();
        }
        public Person UpdatePerson(Person entity)
        {
            UnitOfWork.PersonRepository.Update(entity);
            return entity;
        }
    }
}
