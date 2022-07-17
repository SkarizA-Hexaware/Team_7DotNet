using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_7WebAPI.Model;
using Team_7WebAPI.Repository;
using Team_7WebAPI.DataAccessLayer;

namespace Team_7WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveInfoController : ControllerBase
    {
        private readonly ILeave leave;

        public LeaveInfoController(ILeave leave)
        {
            this.leave = leave;
        }
        [HttpGet]
        [Route("ShowAll_Leaves/{id}")]
        public List<LeaveDetails_View> Leave_List(int? id)
        {
            var list = leave.ShowAllLeaves(id);
            return list;
        }

         [HttpPatch]
        [Route("changestatus/{id}")]

        public int changestate(int? id,LeaveDetails_View leavedetails_view)
        {
            var data = leave.ManagerState(id, leavedetails_view);
            return 1;
        }

        [HttpPut]
        [Route("NewLeave")]

        public async Task<int> AddNewLeave(LeaveDetails_View leaveDetails_View)
        {
            var newleave = await leave.NewLeave( leaveDetails_View);
            return 1;
        }
    }
}
