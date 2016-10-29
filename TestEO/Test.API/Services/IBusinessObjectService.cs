using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.BusinessLayer.Contracts;

namespace Test.API.Services
{
    public interface IBusinessObjectService
    {
        ITestBusinessObject GetBusinessObject();
    }
}
