using GraphQL.Types;

namespace PrototypingASPNETCoreWithGraphQL.Models.GraphQLModels
{
    public class PersonMutation : ObjectGraphType
    {
        public PersonMutation(IPersonRepository personRepository)
        {
            Field<PersonType>("saveperson",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<PersonInputType>> { Name = "person" }),
                resolve: context =>
                {
                    var person = context.GetArgument<Person>("person");
                    return personRepository.Save(person);
                });

            Field<PersonType>("deleteperson",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    return personRepository.Delete(context.GetArgument<int>("id"));
                });
        }
    }
}
