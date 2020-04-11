using GraphQL.Types;

namespace PrototypingASPNETCoreWithGraphQL.Models.GraphQLModels
{
    public class PersonType : ObjectGraphType<Person>
    {
        public PersonType()
        {
            Name = "Person";
            Field(x => x.Id).Description("Person id");
            Field(x => x.Name, nullable: false).Description("Person name");
            Field(x => x.Surname, nullable: false).Description("Person surname");
            Field(x => x.Email, nullable: true).Description("Email of person");
        }
    }
}
