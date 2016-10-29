using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.BusinessLayer.Contracts;
using Test.Domain.DataLayer.Contracts;
using Test.Domain.EntityLayer;

namespace Test.Domain.BusinessLayer
{
    public partial class TestBusinessObject : ITestBusinessObject
    {
        protected IUnitOfWork UnitOfWork;
        public TestBusinessObject(IUnitOfWork unitofwork)
        {
            UnitOfWork = unitofwork;
        }


        public void Release()
        {
            if (UnitOfWork != null)
            {
                UnitOfWork.Dispose();
            }
        }

        
    }
}
