using Newtonsoft.Json.Linq;

namespace PrototypingASPNETCoreWithGraphQL.Models.GraphQLModels
{
    public class GraphQLQueries
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public JObject Variables { get; set; }
    }
}