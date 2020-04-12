using System.Linq;

namespace PrototypingASPNETCoreWithGraphQL.Models
{
    public interface IPersonRepository
    {
        IQueryable<Person> Persons { get; }

        Person GetPersonById(int id);

        Person Save(Person person);

        Person Delete(int id);
    }
}
