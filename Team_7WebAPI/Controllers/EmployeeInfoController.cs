using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_7WebAPI.Repository;
using Team_7WebAPI.Model;
using AutoMapper;

namespace Team_7WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeInfoController : ControllerBase
    {
        private readonly IEmployee employee;
        private readonly IMapper mapper;

        public EmployeeInfoController(IEmployee employee,IMapper mapper)
        {
            this.employee = employee;
            this.mapper = mapper;
        }
         [HttpGet]
        [Route("ShowAll")]
        public async Task<IActionResult> displayall()
        {
            var ar = await employee.ShowAllEmployee();
            return Ok(ar);
        }
        [HttpGet]
        [Route("FindbyID/{Employee_Id}")]
        public async Task<IActionResult> ShowAllEmployee( int Employee_Id)
        {
            var ar = await employee.SearchById(Employee_Id);
            return Ok(ar);
        }
        [HttpPost]
        [Route("AddEmployee")]
        public async Task<int> AddnewEmployee(EmployeeDetails_View employeeDetails_View)
        {
            var ar = await employee.AddNewEmp(employeeDetails_View);
            return 1;
        }
        [HttpDelete]
        [Route("DeleteEmployee/{Employee_Id?}")]
        public async Task<IActionResult> DeleteEmployee(int? Employee_Id)
        {
            if(Employee_Id!=null)
            {
                await employee.RemoveEmp(Employee_Id);
                return Ok();
            }
            return NotFound();
        }
        [HttpPatch]
        [Route("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee(int? Employee_Id,EmployeeDetails_Db employeeDetails_Db)
        {
            if(Employee_Id!=null)
            {
                await employee.UpdateEmp(Employee_Id, employeeDetails_Db);
                return Ok();
            }
            return NotFound();
        }
        [HttpGet]
        [Route("Login/{email}/{password}")]
        public async Task<int> Login(string email, string password)
        {
            var add = await employee.Login(email,password);
            return 1;
        }
    }
}
