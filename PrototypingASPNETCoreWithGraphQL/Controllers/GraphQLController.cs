using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using PrototypingASPNETCoreWithGraphQL.Models.GraphQLModels;
using System.Threading.Tasks;

namespace PrototypingASPNETCoreWithGraphQL.Controllers
{
    [Route("[controller]")]
    public class GraphQLController : Controller
    {
        private ISchema _schema;
        private IDocumentExecuter _documentExecuter;

        public GraphQLController(ISchema schema, IDocumentExecuter documentExecuter)
        {
            _schema = schema;
            _documentExecuter = documentExecuter;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQueries query)
        {
            var inputs = query.Variables?.ToInputs();
            var executionOptions = new ExecutionOptions
            {
                Schema = _schema,
                Query = query.Query,
                Inputs = inputs
            };

            var result = await _documentExecuter.ExecuteAsync(executionOptions);

            return Ok(result);
        }
    }
}
