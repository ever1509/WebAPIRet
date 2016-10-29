using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.DataLayer.Contracts;
using Test.Domain.DataLayer.Repositories;

namespace Test.Domain.DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        protected Boolean Disposed = false;
        protected IPersonRepository _personRepository;
        public IPersonRepository PersonRepository
        {
            get
            {
                return _personRepository ?? (_personRepository = new PersonRepository());
            }
        }

        public int? CommitChanges()
        {
            throw new NotImplementedException();
        }        
        public void Dispose()
        {
            Disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
