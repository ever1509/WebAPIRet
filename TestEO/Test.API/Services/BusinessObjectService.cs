using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Domain.BusinessLayer;
using Test.Domain.BusinessLayer.Contracts;
using Test.Domain.DataLayer;

namespace Test.API.Services
{
    public class BusinessObjectService : IBusinessObjectService
    {
        public ITestBusinessObject GetBusinessObject()
        {
            return new TestBusinessObject(new UnitOfWork());
        }
    }
}