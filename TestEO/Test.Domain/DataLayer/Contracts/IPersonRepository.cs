using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.EntityLayer;

namespace Test.Domain.DataLayer.Contracts
{
    public interface IPersonRepository:IRepository<Person>
    {
    }
}
