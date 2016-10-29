using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Test.API.Responses
{
    public class SingleResponse<TModel>:ISingleResponse<TModel>
    {
        [DataMember(Name ="errorMessage")]
        public String ErrorMessage { get; set; }
        [DataMember(Name = "message")]
        public String Message { get; set; }
        [DataMember(Name = "didError")]
        public Boolean DidError { get; set; }
        [DataMember(Name = "model")]
        public TModel Model { get; set; }
    }
}