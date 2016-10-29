using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Test.Domain.EntityLayer;

namespace Test.API.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {

        }
        public PersonViewModel(Person person)
        {
            id = person.Id;
            first = person.FirstName;
            last = person.LastName;
        }
        [DataMember(Name="id")]
        public Int32? id { get; set; }
        [DataMember(Name = "first")]
        public String first { get; set; }
        [DataMember(Name = "last")]
        public String last { get; set; }
    }
}