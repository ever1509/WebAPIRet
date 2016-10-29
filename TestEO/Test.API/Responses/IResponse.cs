using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.API.Responses
{
    public interface IResponse
    {
        String ErrorMessage { get; set; }
        String Message { get; set; }
        Boolean DidError { get; set; }
    }
}
