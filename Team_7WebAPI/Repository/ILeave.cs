using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_7WebAPI.Model;


namespace Team_7WebAPI.Repository
{
    public interface ILeave
    {
        List<LeaveDetails_View> ShowAllLeaves(int? id);
        int ManagerState(int? id, LeaveDetails_View leaveDetails_View);
        Task<int> NewLeave(LeaveDetails_View leaveDetails_View);


    }
}
