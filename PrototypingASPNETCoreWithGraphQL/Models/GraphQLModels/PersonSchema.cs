using GraphQL;
using GraphQL.Types;

namespace PrototypingASPNETCoreWithGraphQL.Models.GraphQLModels
{
    public class PersonSchema : Schema
    {
        public PersonSchema(IDependencyResolver dependencyResolver) : base(dependencyResolver)
        {
            Query = dependencyResolver.Resolve<PersonQuery>();
        }
    }
}
