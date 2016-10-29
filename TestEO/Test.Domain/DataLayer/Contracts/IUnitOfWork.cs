using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.DataLayer.Contracts
{
    public interface IUnitOfWork:IDisposable
    {
        Int32? CommitChanges();
        IPersonRepository PersonRepository { get;}

    }
}
