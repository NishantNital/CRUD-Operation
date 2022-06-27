using Microsoft.AspNetCore.Mvc;
using FirstWebApi.Services.Interfaces;
using FirsrtWebApi.Models;

namespace FirstWebApi.Controllers
{
    [Route("Employee")]

    public class EmployeeController : ControllerBase

    {
        private  IEmployeeServices _employeeServices;
        public EmployeeController(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }
        
        // Create

        [HttpPost("Create")]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            _employeeServices.CreateEmployee(employee);
            return new JsonResult("Employee Cerated Succesfully");
        }

        // Read 
        [HttpGet("GetEmployeesById/{id}")]
        public IActionResult GetEmployees([FromRoute] int id)
        {
            return new JsonResult(_employeeServices.GetEmployeeById(id));
        }

        [HttpGet("GetEmployees")]
        public IActionResult GetEmployee()
        {
            return new JsonResult(_employeeServices.GetEmployees());
        }

        //Update

        [HttpPut("Update")]
        public IActionResult UpdateEmployee([FromBody] Employee employee)
        {
            _employeeServices.UpdateEmployee(employee);
            return new JsonResult("Employee updated Succesfully");
        }

        //Delete

        [HttpDelete("Delete")]
        public IActionResult DeleteEmployee([FromQuery] int id)
        {
            return new JsonResult(_employeeServices.DeleteEmployee(id));
        }
    }
}
