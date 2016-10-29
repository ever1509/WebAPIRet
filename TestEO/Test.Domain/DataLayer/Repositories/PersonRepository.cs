using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.DataLayer.Contracts;
using Test.Domain.EntityLayer;

namespace Test.Domain.DataLayer.Repositories
{
    public class PersonRepository:Repository<Person>,IPersonRepository
    {
        protected List<Person> persons;
        public PersonRepository()
        {
            persons = new List<Person>()
            {
                new Person() { Id=1,FirstName="Ever", LastName="Orellana" },
                new Person() { Id=2,FirstName="Manuel", LastName="Arevalo" },
                new Person() { Id=3,FirstName="Andrea", LastName="Villalta" },
                new Person() { Id=4,FirstName="Kevin", LastName="Molina" },
                new Person() { Id=5,FirstName="Milton", LastName="Reyes" },
                new Person() { Id=6,FirstName="Maritza", LastName="Fernandez" }
            };
        }
        public override void Add(Person entity)
        {
            persons.Add(entity);
        }
        public override void Update(Person entity)
        {
            persons.ForEach(x =>
            {
                if (x.Id == entity.Id)
                {
                    x.FirstName = entity.FirstName;
                    x.LastName = entity.LastName;
                }
            });
        }
        public override void Remove(Person entity)
        {
            persons.Remove(entity);
        }
        public override IEnumerable<Person> GetAll()
        {
            return persons;
        }
        public override Person Get(Person entity)
        {
            return persons.FirstOrDefault(p => p.Id == entity.Id);
        }
    }
}
