using System.Linq;

namespace PrototypingASPNETCoreWithGraphQL.Models
{
    public interface IPersonRepository
    {
        IQueryable<Person> Persons { get; }

        void Save(Person person);

        void Delete(int id);
    }
}
