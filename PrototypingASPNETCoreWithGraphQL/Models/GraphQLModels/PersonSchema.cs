using GraphQL;
using GraphQL.Types;

namespace PrototypingASPNETCoreWithGraphQL.Models.GraphQLModels
{
    public class PersonSchema : Schema
    {
        // Query ve mutations'larimizi register ettigimiz yer Schema'dir.
        // Constructor'ına bir bir di container alir.
        // Bu di Resolve ile cözülerek Query ve Mutations atanir.
        public PersonSchema(IDependencyResolver dependencyResolver) : base(dependencyResolver)
        {
            Query = dependencyResolver.Resolve<PersonQuery>();
            Mutation = dependencyResolver.Resolve<PersonMutation>();
        }
    }
}
