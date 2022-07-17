using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_7WebAPI.Repository;
using Team_7WebAPI.Model;

namespace Team_7WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerInfoController : ControllerBase
    {
        private readonly IManager manager;

        public ManagerInfoController(IManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        [Route("ShowAllManager")]
        public async Task<IActionResult> displayall()
        {
            var ar = await manager.GetAllManager();
            return Ok(ar);
        }
        [HttpGet]
        [Route("ShowByID")]
        public async Task<IActionResult> ShowByID(int Employee_Id)
        {
            var ar = await manager.SearchById(Employee_Id);
            return Ok(ar);
        }
        [HttpPost]
        [Route("AddNewManager")]
        public async Task<int> AddnewManager(ManagerDetails_View  managerDetails_View)
        {
            var ar = await manager.AddNewManager(managerDetails_View);
            return 1;
        }
        [HttpDelete]
        [Route("DeleteManager/{Employee_Id?}")]
        public async Task<IActionResult> DeleteManager(int? Employee_Id)
        {
            if (Employee_Id != null)
            {
                await manager.RemoveManager(Employee_Id);
                return Ok();
            }
            return NotFound();
        }
        [HttpPatch]
        [Route("UpdateManager/{Employee_Id?}")]
        public async Task<IActionResult> UpdateManager(int? Employee_Id, ManagerDetails_Db managerDetails_Db)
        {
            if (Employee_Id != null)
            {
                await manager.UpdateManager(Employee_Id,managerDetails_Db);
                return Ok();
            }
            return NotFound();
        }


    }
}

