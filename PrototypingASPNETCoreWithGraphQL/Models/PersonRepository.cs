using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypingASPNETCoreWithGraphQL.Models
{
    public class PersonRepository : IPersonRepository
    {
        private PrototypingASPNETCoreWithGraphQLDbContext context;

        public PersonRepository(PrototypingASPNETCoreWithGraphQLDbContext dbContext)
        {
            context = dbContext;
        }

        public IQueryable<Person> Persons => context.Person;
        
        public void Save(Person person)
        {
            Person _person = context.Person.FirstOrDefault(x => x.Id == person.Id);

            if (_person == null)
                context.Add(_person);
            else
            {
                _person.Name = person.Name;
                _person.Surname = person.Surname;
                _person.Email = person.Email;
            }

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Person _person = context.Person.FirstOrDefault(x => x.Id == id);
            
            if(_person == null)
                return;
            else
            {
                context.Remove(_person);
                context.SaveChanges();
            }
        }
    }
}
