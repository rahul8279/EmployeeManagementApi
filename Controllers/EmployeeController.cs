using EmployeeManagementApi.DTOs;
using EmployeeManagementApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementApi.Controllers
{
    [ApiController]
    [Route("api/v1/employees")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(_service.GetEmployees());
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            return Ok(_service.GetEmployeeById(id));
        }
        [HttpPost]
        public IActionResult CreateEmployee(CreateEmployeeDto dto)
        {
            return Ok(_service.CreateEmployee(dto));
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            _service.DeleteEmployee(id);
            return Ok(NoContent());
        }
        [HttpPut("{id}")]

        public IActionResult UpdateEmployee(int id, UpdateEmployeeDto dto)
        {
            _service.UpdateEmployee(id, dto);
            return Ok(NoContent());
        }
    }
}