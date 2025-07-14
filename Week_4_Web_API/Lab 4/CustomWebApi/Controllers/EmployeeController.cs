using CustomWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // 🔒 In-memory hardcoded list (static shared across all requests)
        private static List<Employee> _employeeList = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Salary = 50000,
                Permanent = true,
                DateOfBirth = new DateTime(1990, 5, 24),
                Department = new Department { Id = 1, Name = "IT" },
                Skills = new List<Skill>
                {
                    new Skill { Id = 1, Name = "C#" },
                    new Skill { Id = 2, Name = "SQL" }
                }
            },
            new Employee
            {
                Id = 2,
                Name = "Jane",
                Salary = 60000,
                Permanent = false,
                DateOfBirth = new DateTime(1992, 8, 18),
                Department = new Department { Id = 2, Name = "HR" },
                Skills = new List<Skill>
                {
                    new Skill { Id = 3, Name = "Communication" }
                }
            }
        };

        // ✅ GET: /api/Employee
        [HttpGet]
        public ActionResult<List<Employee>> GetAll()
        {
            return Ok(_employeeList);
        }

        // ✅ POST: /api/Employee
        [HttpPost]
        public IActionResult Create([FromBody] Employee emp)
        {
            if (emp == null || emp.Id <= 0)
                return BadRequest("Invalid employee data");

            _employeeList.Add(emp);

            return Ok(new
            {
                Message = "Employee added successfully",
                Data = emp
            });
        }

        // ✅ PUT: /api/Employee
        [HttpPut]
        [ProducesResponseType(typeof(Employee), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Employee> UpdateEmployee([FromBody] Employee updatedEmp)
        {
            if (updatedEmp == null || updatedEmp.Id <= 0)
                return BadRequest("Invalid employee id");

            var emp = _employeeList.FirstOrDefault(e => e.Id == updatedEmp.Id);
            if (emp == null)
                return BadRequest("Invalid employee id");

            // Simulate update
            emp.Name = updatedEmp.Name;
            emp.Salary = updatedEmp.Salary;
            emp.Permanent = updatedEmp.Permanent;
            emp.Department = updatedEmp.Department;
            emp.Skills = updatedEmp.Skills;
            emp.DateOfBirth = updatedEmp.DateOfBirth;

            return Ok(emp);
        }

        // ✅ DELETE: /api/Employee/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var emp = _employeeList.FirstOrDefault(e => e.Id == id);
            if (emp == null)
                return NotFound("Employee not found");

            _employeeList.Remove(emp);
            return Ok(new
            {
                Message = "Employee deleted",
                DeletedId = id
            });
        }
    }
}
