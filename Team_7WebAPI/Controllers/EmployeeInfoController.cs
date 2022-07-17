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
        [Route("Allemp")]
        public async Task<IActionResult> displayall()
        {
            var ar = await employee.GetAllEmployee();
            return Ok(ar);
        }
        [HttpGet]
        [Route("ShowSpecific")]
        public async Task<IActionResult> ShowSpecific( int EmployeeId)
        {
            var ar = await employee.SearchById(EmployeeId);
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
        [Route("DeleteEmployee/{EmployeeId?}")]
        public async Task<IActionResult> DeleteEmployee(int? EmployeeId)
        {
            if(EmployeeId!=null)
            {
                await employee.RemoveEmp(EmployeeId);
                return Ok();
            }
            return NotFound();
        }
        [HttpPatch]
        [Route("UpdateEmployee/{EmployeeId?}")]
        public async Task<IActionResult> UpdateEmployee(int? EmployeeId,EmployeeDetails_Db employeeDetails_Db)
        {
            if(EmployeeId!=null)
            {
                await employee.UpdateEmp(EmployeeId, employeeDetails_Db);
                return Ok();
            }
            return NotFound();
        }
    }
}
