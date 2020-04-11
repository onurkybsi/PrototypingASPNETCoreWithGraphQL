using System.Linq;

namespace PrototypingASPNETCoreWithGraphQL.Models
{
    public interface IPersonRepository
    {
        IQueryable<Person> Persons { get; }

        Person GetPerson(int id);

        void Save(Person person);

        void Delete(int id);
    }
}
