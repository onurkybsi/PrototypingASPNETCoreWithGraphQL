using GraphQL.Types;

namespace PrototypingASPNETCoreWithGraphQL.Models.GraphQLModels
{
    // Mutation'lardaki insert ve update islemleri icin input alacagimiz bir model olusturduk
    public class PersonInputType : InputObjectGraphType
    {
        public PersonInputType()
        {
            Field<IntGraphType>("id").Description = "If this parameter is assigned, the update is performed.";
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<NonNullGraphType<StringGraphType>>("surname");
            Field<StringGraphType>("email");
        }
    }
}
