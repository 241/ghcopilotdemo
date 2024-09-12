using Microsoft.AspNetCore.Mvc;
using MyMicroservice.Repositories;
using static MyMicroservice.Repositories.SQLChatterRepository;

namespace GHCopilotSQLChatter_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SQLChatterController : ControllerBase
    {

        private readonly SQLChatterRepository _SQLChatterRepository;
        public SQLChatterController(SQLChatterRepository customerRepository)
        {
            _SQLChatterRepository = customerRepository;
        }

        //https://localhost:7275/api/customer/execute-query
        [HttpPost("execute-query")]
        public ActionResult<QueryResult> ExecuteQuery([FromBody] string query)
        {
            var result = _SQLChatterRepository.ExecuteQuery(query);
            return Ok(result);
        }
    }
}
