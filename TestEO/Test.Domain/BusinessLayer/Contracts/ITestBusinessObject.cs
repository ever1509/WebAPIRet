using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.EntityLayer;

namespace Test.Domain.BusinessLayer.Contracts
{
    public interface ITestBusinessObject:IBusinessObject
    {
        IEnumerable<Person> GetPersons();
        Person GetPerson(Person entity);
        Person CreatePerson(Person entity);
        Person UpdatePerson(Person entity);
        Person DeletePerson(Person entity);

    }
}
