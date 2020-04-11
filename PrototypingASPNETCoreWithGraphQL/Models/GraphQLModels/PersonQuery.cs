using GraphQL.Types;

namespace PrototypingASPNETCoreWithGraphQL.Models.GraphQLModels
{
    // Person icin alacagim Query'leri tanimliyorum.
    public class PersonQuery : ObjectGraphType
    {
        public PersonQuery(IPersonRepository personRepository)
        {
            // Ilk parametre query name'i oluyor.Client bu name'i ile istek atiyor.
            // Ikinci parametrede bu query'i nasil resolve edecegimizi giriyoruz.
            Field<ListGraphType<PersonType>>("getallpersons",
                resolve: context => personRepository.Persons);
        }
    }
}