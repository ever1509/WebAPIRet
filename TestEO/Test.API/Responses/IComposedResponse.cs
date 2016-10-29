using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.API.Responses
{
    public interface IComposedResponse<TModel>:IResponse
    {
        IEnumerable<TModel> Model { get; set; }
    }
}
