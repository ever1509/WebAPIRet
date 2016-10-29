using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.EntityLayer
{
    public class Person
    {
        public Person()
        {

        }
        public Person(Int32? personid)
        {
            Id = personid;
        }        
        public Int32? Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
    }
}
