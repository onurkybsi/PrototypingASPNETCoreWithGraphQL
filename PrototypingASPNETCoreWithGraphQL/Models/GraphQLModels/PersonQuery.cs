using GraphQL.Types;

namespace PrototypingASPNETCoreWithGraphQL.Models.GraphQLModels
{
    public class PersonQuery : ObjectGraphType
    {
        public PersonQuery(IPersonRepository personRepository)
        {
            Field<ListGraphType<PersonType>>("getallperson",
                resolve: context => personRepository.Persons);
        }
    }
}