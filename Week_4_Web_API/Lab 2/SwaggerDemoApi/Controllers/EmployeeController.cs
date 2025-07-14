using Microsoft.AspNetCore.Mvc;

namespace SwaggerDemoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class EmployeeController : ControllerBase
    {
        private static readonly List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR" },
            new Employee { Id = 2, Name = "Bob", Department = "IT" }
        };

        // GET api/employee
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Ok(employees);
        }

        // POST api/employee
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Post([FromBody] Employee emp)
        {
            employees.Add(emp);
            return Ok();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
